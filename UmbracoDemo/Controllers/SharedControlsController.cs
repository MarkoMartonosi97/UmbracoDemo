using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoDemo.Controllers
{
    public class SharedControlsController : SurfaceController
    {
        private const string PARTIAL_VIEW_DIR = "~/Views/Partials/SharedControls/";

        public ActionResult RenderTitleControls()
        {
            return PartialView(PARTIAL_VIEW_DIR + "_TitleControls.cshtml");
        }
    }
}