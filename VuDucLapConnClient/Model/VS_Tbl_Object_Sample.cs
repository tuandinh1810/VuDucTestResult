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
    
    public partial class VS_Tbl_Object_Sample
    {
        public string ObjectID { get; set; }
        public string SampleID { get; set; }
        public double Cost { get; set; }
        public string UserI { get; set; }
        public System.DateTime Intime { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual tbl_Object tbl_Object { get; set; }
        public virtual VS_Tbl_Sample VS_Tbl_Sample { get; set; }
    }
}
