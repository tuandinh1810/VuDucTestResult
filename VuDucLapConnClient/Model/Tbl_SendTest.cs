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
    
    public partial class Tbl_SendTest
    {
        public int AutoID { get; set; }
        public System.DateTime DateSend { get; set; }
        public string SID { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string SIDRefer { get; set; }
        public string TestCodeRefer { get; set; }
        public string Result { get; set; }
        public double Cost { get; set; }
        public string LocatID { get; set; }
        public string UserIn { get; set; }
        public System.DateTime Intime { get; set; }
        public string STS { get; set; }
        public System.Guid rowguid { get; set; }
    }
}