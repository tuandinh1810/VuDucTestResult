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
    
    public partial class VS_Tbl_Result_Antibiotic_HIS
    {
        public int AutoID { get; set; }
        public string SID { get; set; }
        public string SampleID { get; set; }
        public string BacteriumID { get; set; }
        public string AntibioticID { get; set; }
        public string AntibioticName { get; set; }
        public Nullable<double> Result { get; set; }
        public Nullable<double> ResultMIC { get; set; }
        public string SRI { get; set; }
        public string SRIMIC { get; set; }
        public Nullable<double> LowInside { get; set; }
        public Nullable<double> Low { get; set; }
        public Nullable<double> High { get; set; }
        public Nullable<double> HighInside { get; set; }
        public Nullable<double> LowInsideMIC { get; set; }
        public Nullable<double> LowMIC { get; set; }
        public Nullable<double> HighMIC { get; set; }
        public Nullable<double> HighInsideMIC { get; set; }
        public string LowInsideStr { get; set; }
        public string LowHighStr { get; set; }
        public string HighInsideStr { get; set; }
        public string LowInsideMICStr { get; set; }
        public string LowHighMICStr { get; set; }
        public string HighInsideMICStr { get; set; }
        public string Unit { get; set; }
        public string UnitMIC { get; set; }
        public string UserI { get; set; }
        public System.DateTime Intime { get; set; }
        public string UserU { get; set; }
        public string UserUMIC { get; set; }
        public Nullable<System.DateTime> Updatetime { get; set; }
        public Nullable<System.DateTime> UpdatetimeMIC { get; set; }
        public string ExternalCode { get; set; }
        public string OrderID { get; set; }
        public string HISCode { get; set; }
        public string AntibioticHIS { get; set; }
        public bool ESBLChange { get; set; }
        public string SRIESBL { get; set; }
        public System.Guid rowguid { get; set; }
    }
}
