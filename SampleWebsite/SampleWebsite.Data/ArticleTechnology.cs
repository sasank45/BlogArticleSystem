
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
    
public partial class ArticleTechnology
{

    public int Id { get; set; }

    public long ArticleId { get; set; }

    public int TechnologyId { get; set; }

    public int CreatedBy { get; set; }

    public System.DateTime CreatedDate { get; set; }

    public bool IsActive { get; set; }



    public virtual Article Article { get; set; }

    public virtual Technology Technology { get; set; }

}

}
