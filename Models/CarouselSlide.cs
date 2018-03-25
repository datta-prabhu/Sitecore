using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCookbook.Models
{
    public class CarouselSlide: CustomItem
    {
        public CarouselSlide(Item item)
            : base(item)
        { }

        public string Title
        {
            get
            {
                return InnerItem["Title"];
            }
        }
        public MvcHtmlString Image
        {
            get
            {
                return new MvcHtmlString(FieldRenderer.Render(InnerItem, "Image"));
            }
        }

        public string Url
        {
            get
            {
                Item linkItem = Sitecore.Context.Database.GetItem(InnerItem["Link Item"]);
                if (linkItem != null)
                    return LinkManager.GetItemUrl(linkItem);
                return "";
            }
        }
    }


    public class CarouselSlidex 
    {
        public CarouselSlidex(Item item)
            
        { 
            this.Title=item.Name;
            this.Image=new MvcHtmlString(FieldRenderer.Render(item, "Image"));
            this.Urlx=GetItemURL(item);
        }

       private string GetItemURL(Item item)
       {
           Item linkItem = Sitecore.Context.Database.GetItem(item["Link Item"]);
                if (linkItem != null)
                    return LinkManager.GetItemUrl(linkItem);
                return "";
       
       }

        public string Title
        {
            get;

            set;
        }
        public MvcHtmlString Image
        {
            get;
            set;
       }

        public string Urlx
        {
            get;
            set;
        
        }
    }

}