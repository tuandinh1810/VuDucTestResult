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
    
    public partial class Tbl_Order_HIS
    {
        public int AutoID { get; set; }
        public string Seq { get; set; }
        public string OrderID { get; set; }
        public System.DateTime DateOrder { get; set; }
        public string Invoice { get; set; }
        public string PID { get; set; }
        public string PName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sex { get; set; }
        public string ObjectID { get; set; }
        public string Address { get; set; }
        public string DoctorID { get; set; }
        public string LocationID { get; set; }
        public string DiagID { get; set; }
        public string TestCodeHIS { get; set; }
        public System.Guid rowguid { get; set; }
    }
}
