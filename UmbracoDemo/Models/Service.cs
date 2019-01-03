using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoDemo.Models
{
    public class Service
    {

        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Service(string Icon, string Title, string Description)
        {
            this.Icon = Icon;
            this.Title = Title;
            this.Description = Description;
        }
    }
}