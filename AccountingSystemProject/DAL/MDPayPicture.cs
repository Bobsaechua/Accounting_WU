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
    
    public partial class MDPayPicture
    {
        public int PayPicID { get; set; }
        public string PayPicName { get; set; }
        public string PayPicSystem { get; set; }
        public string FullPathName { get; set; }
        public string SystemDefault { get; set; }
        public string BankShortName { get; set; }
        public string BankName { get; set; }
        public string BankNameEng { get; set; }
        public Nullable<System.DateTime> UpgradeDate { get; set; }
        public Nullable<int> UpgradeVS { get; set; }
        public Nullable<int> PayType { get; set; }
        public string ccode { get; set; }
    }
}
