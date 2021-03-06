
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SampleWebsite.Data
{

using System;
    using System.Collections.Generic;
    
public partial class Article
{

    public Article()
    {

        this.ArticleTechnologies = new HashSet<ArticleTechnology>();

    }


    public long Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int ArticleType { get; set; }

    public int ArticleStatus { get; set; }

    public int CreatedBy { get; set; }

    public System.DateTime CreatedDate { get; set; }

    public Nullable<int> ModifiedBy { get; set; }

    public Nullable<System.DateTime> ModifiedDate { get; set; }



    public virtual ArticleType ArticleType1 { get; set; }

    public virtual Status Status { get; set; }

    public virtual ICollection<ArticleTechnology> ArticleTechnologies { get; set; }

}

}
