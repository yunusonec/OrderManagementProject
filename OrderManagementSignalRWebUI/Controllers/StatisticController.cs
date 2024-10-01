using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSignalRWebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
