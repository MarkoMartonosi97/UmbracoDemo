using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoDemo.Models
{
    public class ClientTestimonial
    {
        public string Text { get; set; }
        public string Client { get; set; }
        //public string Link { get; set; }


        //Get the icon for the Link
        //public string LinkIcon
        //{
        //    get
        //    {
        //        if (Link.Contains("google.com"))
        //        {
        //            return "icon-google-plus googleplus-color";
        //        }
        //        else if (Link.Contains("twitter.com"))
        //        {
        //            return "icon-twitter twitter-color";
        //        }
        //        return "";
        //    }
        //}

        public ClientTestimonial(string Text, string Client)
        {
            this.Text = Text;
            this.Client = Client;
        }
    }
}