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
    
    public partial class tbl_User_QuickCode
    {
        public int AutoID { get; set; }
        public string UserID { get; set; }
        public string TestCode { get; set; }
        public string UserQuickCode { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual tbl_TestCode tbl_TestCode { get; set; }
    }
}
