using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ApplicationDbContext.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using WebApplication.Controllers;
using DTO.Client;
using Services.Client;
using System.Diagnostics;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using AspNetIdentityDbContext;
using DTO.Shared;
using DTO.Utils;


namespace WebApplication.Controllers
{

    public class ClientAddressController : Controller
    {

        private readonly ClientServices clientServices;

        public ClientAddressController(ApplicationDbContext.Context.ApplicationDbContext context, UserManager<AspNetIdentityDbContext.User> userManager,  ClientServices clientServices)
        {
            this.clientServices = clientServices;
        }

        public async Task<IActionResult> Manage(AddressClientViewModel model)
        {
          
        }

        [HttpPost]
        [ActionName("List")]
        public async Task<IActionResult> List(DTO.Shared.DataTablesAjaxPostModel filter)
           
        }
        public async Task<IActionResult> RemoveClient(int id)
        {
           
        }
    }
