//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sql01
{
    using System;
    using System.Collections.Generic;
    
    public partial class person
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string rank { get; set; }
        public bool active { get; set; }
        public int unitID { get; set; }
        public Nullable<int> region { get; set; }
    
        public virtual region region1 { get; set; }
        public virtual unit01 unit01 { get; set; }
    }
}