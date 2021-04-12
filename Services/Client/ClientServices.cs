using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDbContext.Models;
using DTO.Client;
using DTO.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Services.Shared;

namespace Services.Client
{
    public class ClientServices : BasicServices<ApplicationDbContext.Models.Client, DTO.Client.ClientViewModel>
    {
        private readonly UserManager<AspNetIdentityDbContext.User> userManager;

        public ClientServices(ApplicationDbContext.Context.ApplicationDbContext context, UserManager<AspNetIdentityDbContext.User> userManager)
            : base(context, "ClientId")
        {
            this.userManager = userManager;
        }

        public override int Create(ClientViewModel model)
        {


            var Client = new ApplicationDbContext.Models.Client
            {
                ClientId = model.ClientId,
                Name = model.Name,
                Email = model.Email,
                CpfCnpjDocument = model.CpfCnpjDocument,
                TypeClient = model.TypeClient

            };

            this.dbSet.Add(Client);
            this.context.SaveChanges();

            return Client.ClientId;
        }

        public override void Delete(object id)
        {
            var client = this.GetDataByID(id);



            this.context.Update(client);
            this.context.SaveChanges();
        }

        public void Delete(object id, int userId)
        {
            var client = this.GetDataByID(id);



            this.context.Update(client);
            this.context.SaveChanges();
        }

        public override List<ClientViewModel> GetDataViewModel(IEnumerable<ApplicationDbContext.Models.Client> data)
        {
            return (from y in data
                    select new DTO.Client.ClientViewModel()
                    {
                        ClientId = y.ClientId,
                        Name = y.Name,
                        Email = y.Email,
                        CpfCnpjDocument = y.CpfCnpjDocument,
                        TypeClient = y.TypeClient
                    }).ToList();
        }

        public override ClientViewModel GetDataViewModel(ApplicationDbContext.Models.Client data)
        {

            return new DTO.Client.ClientViewModel()
            {
                ClientId = data.ClientId,
                Name = data.Name,
                Email = data.Email,
                CpfCnpjDocument = data.CpfCnpjDocument,
                TypeClient = data.TypeClient,

            };
        }


        public override void Update(ClientViewModel model)
        {
            var Client = this.GetDataByID(model.ClientId);

            Client.ClientId = model.ClientId;
            Client.Name = model.Name;
            Client.Email = model.Email;
            Client.CpfCnpjDocument = model.CpfCnpjDocument;
            Client.TypeClient = model.TypeClient;


            this.context.Update(Client);
            this.context.SaveChanges();
        }

        protected override void SetDbSet()
        {
            this.dbSet = context.Client;
        }

    }


}
