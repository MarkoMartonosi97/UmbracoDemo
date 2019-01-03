using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoDemo.Models;

namespace UmbracoDemo.Controllers
{
    public class ServiceController : SurfaceController
    {

        private const string PARTIAL_VIEW_DIR = "~/Views/Partials/Service/";

        public ActionResult RenderServicesList()
        {
            List<Service> ServiceList = new List<Service>();
            IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");

            List<IPublishedContent> model = (List<IPublishedContent>)homePage.GetPropertyValue("serviceItemList");


            //-----------ZASAD, ISPRAVI
            foreach (var x in model.Take(3))
            {
                //Get the name of the icon. eg 'heart.png'
                //assign class to service item as the 'sl-icon'+icon name so that it would reference a icon in the font
                var Icon = x.GetPropertyValue("serviceIcon");
                string IconName = ((IPublishedContent)Icon).Name;
                string IconClass = "sl-icon-" + IconName.Split('.')[0];

                var Title = x.GetPropertyValue("serviceTitle");
                var Description = x.GetPropertyValue("serviceDescription");

                ServiceList.Add(new Service(IconClass, Title.ToString(), Description.ToString()));
            }
            return PartialView(PARTIAL_VIEW_DIR + "_Services.cshtml", ServiceList);
        }
    }
}