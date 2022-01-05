using Student_Management_Sysytem.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Student_Management_Sysytem.Models;
namespace Student_Management_Sysytem.Controllers
{
    public class LoginController : Controller
    {
        AppDBContext db = new AppDBContext();
        // GET: Login
        public ActionResult LoginIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginIndex(AdminLogin log)
        {
            var Validuser = db.AdminLogins.Where(x => x.Name == log.Name && x.Password == log.Password).FirstOrDefault();
            if (Validuser != null)
            {

                if (Validuser.Role == "Admin")
                {

                    return RedirectToAction("DashboardIndex", "Dashboard");

                }

                else if (Validuser.Role == "Teacher")
                {
                    return RedirectToAction("Index", "Teachers");
                }
                else if (Validuser.Role == "Student")
                {
                    return RedirectToAction("Index", "Students");
                }


            }
            ModelState.AddModelError("", "Invalid USername and Password");
            return View();
        }

       public ActionResult  Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginIndex");

;
        }
    }
}




 


   

       
    
