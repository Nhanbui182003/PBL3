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
    
    public partial class Document
    {
        public int ID { get; set; }
        public Nullable<int> Class_ID { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
    
        public virtual Class Class { get; set; }
    }
}
