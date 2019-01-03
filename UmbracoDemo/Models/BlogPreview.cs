using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoDemo.Models
{
    public class BlogPreview
    {
        public string Name { get; set; }
        public string Introduction { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }

        public int Sort { get; set; } //Not Paul Seal

        public BlogPreview(string Name, string Introduction, string ImageUrl, string LinkUrl, int Sort)
        {
            this.Name = Name;
            this.Introduction = Introduction;
            this.ImageUrl = ImageUrl;
            this.LinkUrl = LinkUrl;
            this.Sort = Sort;
        }
    }
}