﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ShareAdmin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ShareAdminControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}