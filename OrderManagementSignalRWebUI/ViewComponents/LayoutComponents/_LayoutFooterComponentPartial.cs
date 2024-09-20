using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSignalRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }    
    }
}
