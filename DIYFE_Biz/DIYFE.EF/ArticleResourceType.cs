//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIYFE.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ArticleResourceType
    {
        public ArticleResourceType()
        {
            this.ArticleResources = new HashSet<ArticleResource>();
        }
    
        public int ArticleResourceTypeId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<ArticleResource> ArticleResources { get; set; }
    }
}