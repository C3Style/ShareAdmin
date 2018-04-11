using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ShareAdmin.Web.Controllers
{
    public class MainController : ShareAdminControllerBase
    {
        public ActionResult Main(string returnUrl = "")
        {
            return View("Main", null);
        }
    }
}