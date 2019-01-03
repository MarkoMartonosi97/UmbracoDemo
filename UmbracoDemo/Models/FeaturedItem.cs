using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoDemo.Models
{
    public class FeaturedItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }


        public FeaturedItem(string Name, string Category, string ImageUrl, string LinkUrl)
        {
            this.Name = Name;
            this.Category = Category;
            this.ImageUrl = ImageUrl;
            this.LinkUrl = LinkUrl;
        }
    }
}