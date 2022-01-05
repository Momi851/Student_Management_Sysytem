using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_Sysytem.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult RegistrationIndex()
        {
            return View();
        }
    }
}