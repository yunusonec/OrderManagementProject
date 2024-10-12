using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSignalRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View(); 
        }
    }
}
