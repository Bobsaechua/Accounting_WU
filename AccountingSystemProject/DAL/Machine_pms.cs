//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingSystemProject.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Machine_pms
    {
        public int refmac_id { get; set; }
        public string maccode { get; set; }
        public string regcode { get; set; }
        public Nullable<decimal> price { get; set; }
        public string supcode { get; set; }
        public decimal dep { get; set; }
        public Nullable<System.DateTime> endinsure { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public string loc { get; set; }
        public Nullable<int> status { get; set; }
        public string usestyle { get; set; }
        public Nullable<int> refaps { get; set; }
        public byte[] mac_img { get; set; }
        public string note01 { get; set; }
        public string note02 { get; set; }
        public string note03 { get; set; }
        public string note04 { get; set; }
        public string note05 { get; set; }
        public string note06 { get; set; }
        public string note07 { get; set; }
        public string note08 { get; set; }
        public string note09 { get; set; }
        public string note10 { get; set; }
        public string other_text { get; set; }
        public Nullable<int> gl_id { get; set; }
    }
}
