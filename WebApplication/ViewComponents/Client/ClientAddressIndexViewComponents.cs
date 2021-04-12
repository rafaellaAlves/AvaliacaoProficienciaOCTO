using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.Shared;
using Microsoft.AspNetCore.Mvc;
using Services.Client;

namespace WebApplication.ViewComponents.Client
{
    public class ClientAddressIndexViewComponents : ViewComponent
    {
        private readonly AddressClientServices service;
        public ClientAddressIndexViewComponents(AddressClientServices service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(int clientId) => await Task.Run(() => View(clientId));

    }
}
