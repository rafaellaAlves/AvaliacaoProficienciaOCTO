using DTO.Client;
using DTO.Shared;
using DTO.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Services.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using ApplicationDbContext.Models;
using System.Threading.Tasks;
using System.Linq;

namespace Services.Client
{
    public class AddressClientServices : BasicServices<ApplicationDbContext.Models.AddressClient, DTO.Client.AddressClientViewModel>
    {
        private readonly UserManager<AspNetIdentityDbContext.User> userManager;
        public AddressClientServices(ApplicationDbContext.Context.ApplicationDbContext context, UserManager<AspNetIdentityDbContext.User> userManager)
           : base(context, "ClientId")
        {
            this.userManager = userManager;
        }
        public override int Create(AddressClientViewModel model)
        {


            var address = new ApplicationDbContext.Models.AddressClient
            {
                ClientId = model.ClientId,
              Address = model.Address,
              AddressNumber = model.AddressNumber,
              AddressComplement = model.AddressComplement,
              City = model.City,
              Neigborhood = model.Neigborhood,
              State = model.State,
              ZipCode = model.ZipCode,
              TypeAddress = model.TypeAddress

            };

            this.dbSet.Add(address);
            this.context.SaveChanges();

            return address.ClientId;
        }

        public override void Delete(object id)
        {
            var address = this.GetDataByID(id);



            this.context.Update(address);
            this.context.SaveChanges();
        }

        public void Delete(object id, int userId)
        {
            var address = this.GetDataByID(id);



            this.context.Update(address);
            this.context.SaveChanges();
        }

        public override List<AddressClientViewModel> GetDataViewModel(IEnumerable<ApplicationDbContext.Models.AddressClient> data)
        {
            return (from y in data
                    select new DTO.Client.AddressClientViewModel()
                    {
                        ClientId = y.ClientId,
                        Address = y.Address,
                        AddressNumber = y.AddressNumber,
                        AddressComplement = y.AddressComplement,
                        City = y.City,
                        ZipCode = y.ZipCode,
                        Neigborhood = y.Neigborhood,
                        State = y.State,
                        TypeAddress = y.TypeAddress
                       
                    }).ToList();
        }

        public override AddressClientViewModel GetDataViewModel(ApplicationDbContext.Models.AddressClient data)
        {

            return new DTO.Client.AddressClientViewModel()
            {
                ClientId = data.ClientId,
                Address = data.Address,
                AddressComplement = data.AddressComplement,
                AddressNumber = data.AddressNumber,
                TypeAddress = data.TypeAddress,
                City = data.City,
                Neigborhood = data.Neigborhood,
                State = data.State,
                ZipCode = data.ZipCode

            };
        }


        public override void Update(AddressClientViewModel model)
        {
            var address = this.GetDataByID(model.ClientId);

            address.ClientId = model.ClientId;
            address.Address = model.Address;
            address.AddressComplement = model.AddressComplement;
            address.AddressNumber = model.AddressNumber;
            address.Neigborhood = model.Neigborhood;
            address.ZipCode = model.ZipCode;
            address.City = model.City;
            address.State = model.State;
            address.TypeAddress = model.TypeAddress;


            this.context.Update(address);
            this.context.SaveChanges();
        }

        protected override void SetDbSet()
        {
            this.dbSet = context.AddressClient;
        }
    
     
 }
}
