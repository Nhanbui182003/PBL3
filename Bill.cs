//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int Id { get; set; }
        public int LearningResultId { get; set; }
        public bool Status { get; set; }
        public int Price { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
    
        public virtual LearningResult LearningResult { get; set; }
    }
}
