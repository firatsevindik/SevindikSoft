using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sevindik.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Sevindik.Northwind.MvcWebUI.Models;

namespace Abc.Northwind.MvcWebUI.ViewComponents
{
    public class UserSummaryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            UserDetailsViewModel model = new UserDetailsViewModel
            {
               UserName = HttpContext.User.Identity.Name
            };
            return View(model);
        }
    }
}
