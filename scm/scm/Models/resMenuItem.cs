//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace scm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class resMenuItem
    {
        public int Id { get; set; }
        public int resMenuId { get; set; }
        public int resRecipeId { get; set; }
        public int ServingRequired { get; set; }
    
        public virtual resMenu resMenu { get; set; }
        public virtual resRecipe resRecipe { get; set; }
    }
}