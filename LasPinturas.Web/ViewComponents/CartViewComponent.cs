using LasPinturas.Web.Extensions;
using LasPinturas.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LasPinturas.Web.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var collection = HttpContext.Session.GetJson<CartCollection>("sepetim");
            return View(collection);
        }
    }
}
