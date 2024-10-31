using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSignalRWebUI.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
