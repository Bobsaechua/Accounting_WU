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
    
    public partial class Lot
    {
        public string lot_id { get; set; }
        public string pcode { get; set; }
        public decimal cost { get; set; }
        public decimal stock { get; set; }
        public string wcode { get; set; }
        public string bcode { get; set; }
        public string ccode { get; set; }
        public Nullable<decimal> Reserv { get; set; }
    }
}