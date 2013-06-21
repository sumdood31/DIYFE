﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

using DIYFELib;

namespace DIYFEWeb.Models
{
    public class PageBaseModel
    {
        //BASE SEO DATA AND SIMPLE CONTENT
        //public Article ArticleContent = new Article();
        //SEO DATA
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Keywords { get; set; }


        //PAGE VARS, MOSTLY USED FOR JAVASCRIPT
        public string ActiveTopNavLink { get; set; }


    }
}