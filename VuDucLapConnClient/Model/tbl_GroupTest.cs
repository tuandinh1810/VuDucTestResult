//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VuDucLapConnClient.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_GroupTest
    {
        public int AutoID { get; set; }
        public string GroupID { get; set; }
        public string QuickCode { get; set; }
        public string TestCode { get; set; }
        public string ProfileID { get; set; }
        public string UserI { get; set; }
        public string UserU { get; set; }
        public Nullable<System.DateTime> Intime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual tbl_Group tbl_Group { get; set; }
        public virtual tbl_TestCode tbl_TestCode { get; set; }
    }
}
