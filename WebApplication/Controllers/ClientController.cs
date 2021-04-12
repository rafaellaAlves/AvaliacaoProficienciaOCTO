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

namespace WebApplication.Controllers
{
    public class ClientController : Controller
    {

        private readonly ClientServices clientServices;
       

        public ClientController(ClientServices clientServices, UserManager<User> userManager)
        {
            this.clientServices = clientServices;
            
        }
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }
        
        public override async Task<IActionResult> ManageForm(ClientViewModel model)
        {
           


        }
       

        [Authorize(Roles = Constants.AllRolesExceptClient)]
        public override async Task<IActionResult> List(DTO.Shared.DataTablesAjaxPostModel filter)
        {
           
        }
        [Authorize(Roles = Constants.AllRolesExceptClient)]
        public async Task<IActionResult> _Delete(int id)
        {
          
            await base.Delete(id);

            return await Task.Run(() => Json(new { hasError = false }));
        }

    }
}
