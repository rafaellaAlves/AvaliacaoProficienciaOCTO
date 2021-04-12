using ApplicationDbContext.Models;
using DTO.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Services.Shared;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using DTO.Utils;
using Microsoft.AspNetCore.Http;
using System.Linq;
using DTO.Shared;

namespace Services.Client
{
    public class PhoneNumberClientServices : BasicServices<ApplicationDbContext.Models.PhoneNumberClient, DTO.Client.PhoneNumberClientViewModel> { 
        private readonly UserManager<AspNetIdentityDbContext.User> userManager;


        public PhoneNumberClientServices(ApplicationDbContext.Context.ApplicationDbContext context, UserManager<AspNetIdentityDbContext.User> userManager)
           : base(context, "ClientId")
        {
            this.userManager = userManager;
        }

        public override int Create(PhoneNumberClientViewModel model)
        {


            var Phone = new ApplicationDbContext.Models.PhoneNumberClient
            {
                ClientId = model.ClientId,
               PhoneNumber = model.PhoneNumber,
               TypePhoneNumber = model.TypePhoneNumber,

            };

            this.dbSet.Add(Phone);
            this.context.SaveChanges();

            return Phone.ClientId;
        }

        public override void Delete(object id)
        {
            var phone = this.GetDataByID(id);



            this.context.Update(phone);
            this.context.SaveChanges();
        }

        public void Delete(object id, int userId)
        {
            var phone = this.GetDataByID(id);



            this.context.Update(phone);
            this.context.SaveChanges();
        }

        public override List<PhoneNumberClientViewModel> GetDataViewModel(IEnumerable<ApplicationDbContext.Models.PhoneNumberClient> data)
        {
            return (from y in data
                    select new DTO.Client.PhoneNumberClientViewModel()
                    {
                        ClientId = y.ClientId,
                        PhoneNumber = y.PhoneNumber,
                        TypePhoneNumber = y.TypePhoneNumber,
                    }).ToList();
        }

        public override PhoneNumberClientViewModel GetDataViewModel(ApplicationDbContext.Models.PhoneNumberClient data)
        {

            return new DTO.Client.PhoneNumberClientViewModel()
            {
                ClientId = data.ClientId,
                PhoneNumber = data.PhoneNumber,
                TypePhoneNumber = data.TypePhoneNumber,
            };
        }


        public override void Update(PhoneNumberClientViewModel model)
        {
            var phone = this.GetDataByID(model.ClientId);

            phone.ClientId = model.ClientId;
            phone.PhoneNumber = model.PhoneNumber;
            phone.TypePhoneNumber = model.TypePhoneNumber;

            this.context.Update(phone);
            this.context.SaveChanges();
        }

        protected override void SetDbSet()
        {
            this.dbSet = context.PhoneNumberClient;
        }

    }
}
