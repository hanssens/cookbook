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

        [HttpPost]
        public ActionResult SavePartial(Customer model)
        {
            // Just for this demo, add some validations here
            if (String.IsNullOrEmpty(model.DisplayName))
                ModelState.AddModelError("DisplayName", "Name is required");

            return PartialView("_EditCustomer", model);
        }

    }
}
