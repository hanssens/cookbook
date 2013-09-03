using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Hanssens.CookBook.Areas.Samples.Models;

namespace Hanssens.CookBook.Areas.Samples.Controllers
{
    public class AjaxController : Controller
    {

        public ActionResult Index()
        {
            var model = new Customer();
            return View(model);
        }

        public ActionResult SavePartial(Customer model)
        {
            return PartialView("_EditCustomer", model);
        }

    }
}
