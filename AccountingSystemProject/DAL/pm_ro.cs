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
    
    public partial class pm_ro
    {
        public int ro_id { get; set; }
        public string book_no { get; set; }
        public string doc_no { get; set; }
        public string ccode { get; set; }
        public System.DateTime date_ro { get; set; }
        public Nullable<int> doc_status { get; set; }
        public Nullable<int> emp_ro { get; set; }
        public string emp_name { get; set; }
        public Nullable<int> approve_type { get; set; }
        public Nullable<int> emp_approve { get; set; }
        public string note01 { get; set; }
        public string note02 { get; set; }
        public string note03 { get; set; }
        public string note04 { get; set; }
        public string note05 { get; set; }
        public Nullable<int> status_id { get; set; }
        public Nullable<int> level_n { get; set; }
        public Nullable<int> sec_id { get; set; }
        public string emp_approve_name { get; set; }
    
        public virtual pm_ro pm_ro1 { get; set; }
        public virtual pm_ro pm_ro2 { get; set; }
    }
}