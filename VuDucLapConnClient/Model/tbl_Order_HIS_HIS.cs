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
    
    public partial class tbl_Order_HIS_HIS
    {
        public int AutoID { get; set; }
        public string OrderID { get; set; }
        public string TestCode { get; set; }
        public string TestID { get; set; }
        public string PID { get; set; }
        public string PatientName { get; set; }
        public int YearofBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Diagnostic { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string PatientType { get; set; }
        public string DoctorID { get; set; }
        public string WardID { get; set; }
        public System.DateTime Intime { get; set; }
        public System.Guid rowguid { get; set; }
    }
}