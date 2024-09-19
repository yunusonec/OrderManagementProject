using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSignalRWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
