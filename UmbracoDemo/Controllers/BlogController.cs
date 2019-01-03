using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoDemo.Models;

namespace UmbracoDemo.Controllers
{
    public class BlogController : SurfaceController
    {
        private const string PARTIAL_VIEW_DIR = "~/Views/Partials/Blog/";



        //Displayin 6 items in Blog page and 3 items in home page
        public ActionResult RenderPostList(int numberOfItems)
        {
            List<BlogPreview> BlogPreviewItems = new List<BlogPreview>();
            IPublishedContent BlogPage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "blog").FirstOrDefault();


            //List<IPublishedContent> model = (List<IPublishedContent>) BlogPage.GetPropertyValue("featuredItemList");
            IEnumerable<IPublishedContent> BlogPageChildren = BlogPage.Children; //Blog posts



            // Ordering (sort by newest) = BlogPageChildren.OrderByDescending(x => x.UpdateDate)
            // Ordering (sort by sort number from umbraco CMS) = BlogPageChildren.OrderBy(x => x.SortOrder)
            // Taking number of items
            foreach (IPublishedContent page in BlogPageChildren.OrderByDescending(x => x.UpdateDate).Take(numberOfItems))
            {

                var Name = page.Name;

                var Introduction = page.GetPropertyValue("articleIntroduction");

                // ------------------------------------- Mui style
                var Image = page.GetPropertyValue("articleImage");
                string ImageUrl = ((PublishedContentModel)Image).Url;

                // ------------------------------------- Paul Seal style
                //var ImageId = int.Parse(Image.ToString());
                //var mediaItem = Umbraco.Media(ImageId);
                //string ImageUrl = mediaItem.Url;

                var Link = page.Url;
                //string LinkUrl = ((PublishedContentModel)Link).Url;

                BlogPreviewItems.Add(new BlogPreview(Name.ToString(), Introduction.ToString(), ImageUrl, Link, page.SortOrder));
            }




            return PartialView(PARTIAL_VIEW_DIR + "_PostList.cshtml", BlogPreviewItems);
        }

    }
}