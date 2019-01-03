using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoDemo.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        private const string PARTIAL_VIEW_DIR = "~/Views/Partials/SiteLayout/";

        public ActionResult RenderHeader()
        {
            return PartialView(PARTIAL_VIEW_DIR + "_Header.cshtml");
        }


        public ActionResult RenderFooter()
        {
            return PartialView(PARTIAL_VIEW_DIR + "_Footer.cshtml");
        }
    }
}