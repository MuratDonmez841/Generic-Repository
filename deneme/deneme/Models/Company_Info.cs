//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deneme.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company_Info
    {
        public Nullable<int> CompanyID { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public Nullable<long> TelNu { get; set; }
        public int Info_ID { get; set; }
        public string Icon { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
