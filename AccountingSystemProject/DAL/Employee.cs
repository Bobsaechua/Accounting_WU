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
    
    public partial class Employee
    {
        public int eid { get; set; }
        public string ecode { get; set; }
        public string ename1 { get; set; }
        public string ename2 { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string zip { get; set; }
        public string tel { get; set; }
        public string mobile { get; set; }
        public string fax { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public Nullable<decimal> commission { get; set; }
        public Nullable<bool> issale { get; set; }
        public Nullable<int> saleteam { get; set; }
        public Nullable<bool> isusr { get; set; }
        public string ccode { get; set; }
        public string secode { get; set; }
        public Nullable<int> coststatus { get; set; }
    }
}
