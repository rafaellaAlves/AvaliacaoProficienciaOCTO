using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication.ViewComponents.Client
{
    public class ClientManageViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id) => await Task.Run(() => View(id));
    }
}
