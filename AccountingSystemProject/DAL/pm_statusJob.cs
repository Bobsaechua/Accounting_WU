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
    
    public partial class pm_statusJob
    {
        public int status_id { get; set; }
        public string status_code { get; set; }
        public string status_name { get; set; }
        public string status_details { get; set; }
        public Nullable<int> break_machine { get; set; }
        public Nullable<int> doc_ro { get; set; }
        public Nullable<int> doc_wp { get; set; }
        public Nullable<int> doc_wo { get; set; }
    }
}
