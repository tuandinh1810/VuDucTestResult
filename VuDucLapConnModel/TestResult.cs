//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VuDucLapConnModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestResult
    {
        public int AutoID { get; set; }
        public string SID { get; set; }
        public string Testcode { get; set; }
        public string Result { get; set; }
        public string TestName { get; set; }
        public Nullable<System.DateTime> ResultTime { get; set; }
        public string Unit { get; set; }
        public string NormalRange { get; set; }
        public string Category { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
