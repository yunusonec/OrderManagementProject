﻿using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSignalRWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
