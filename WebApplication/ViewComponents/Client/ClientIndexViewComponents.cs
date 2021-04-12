using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication.ViewComponents.Client
{
    public class ClientIndexViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => await Task.Run(() => View());
    }
}
