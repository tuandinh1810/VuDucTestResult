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
    
    public partial class tbl_Result
    {
        public int AutoID { get; set; }
        public string SID { get; set; }
        public string Testcode { get; set; }
        public string Result { get; set; }
        public string Posneg { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public string TestName { get; set; }
        public string NormalRange { get; set; }
        public string NormalRangeF { get; set; }
        public Nullable<byte> PrintOrder { get; set; }
        public Nullable<bool> TestHead { get; set; }
        public string Category { get; set; }
        public Nullable<double> LowerLimit { get; set; }
        public Nullable<double> HigherLimit { get; set; }
        public Nullable<bool> Profile { get; set; }
        public string UserI { get; set; }
        public string UserU { get; set; }
        public string UserD { get; set; }
        public Nullable<System.DateTime> Updatetime { get; set; }
        public bool Download { get; set; }
        public Nullable<System.DateTime> Intime { get; set; }
        public bool Bold { get; set; }
        public string Invoice { get; set; }
        public string Status { get; set; }
        public byte STS { get; set; }
        public byte STSLH { get; set; }
        public double Cost { get; set; }
        public string Comment { get; set; }
        public byte Color { get; set; }
        public string Criteria { get; set; }
        public string Type { get; set; }
        public string UserV { get; set; }
        public string OrderID { get; set; }
        public string TestCodeHIS { get; set; }
        public string PosHIS { get; set; }
        public System.Guid rowguid { get; set; }
        public bool PrintOption { get; set; }
        public byte Align { get; set; }
        public string BarcodeType { get; set; }
        public string BLHigher { get; set; }
        public string BLLower { get; set; }
        public string Boundary { get; set; }
        public double ConvertionNo { get; set; }
        public bool DeltaFlag { get; set; }
        public byte DeltaType { get; set; }
        public Nullable<System.DateTime> DownTime { get; set; }
        public int ExcludeGroup { get; set; }
        public string HigherID { get; set; }
        public Nullable<double> HigherWarning { get; set; }
        public Nullable<int> InsDownload { get; set; }
        public string InsName { get; set; }
        public int InstrumentID { get; set; }
        public Nullable<double> LowerWarning { get; set; }
        public string NormalRange1 { get; set; }
        public string NormalRangeF1 { get; set; }
        public string NormalRangeWarning { get; set; }
        public string NormalRangeWarningF { get; set; }
        public string ProfileID { get; set; }
        public string Range { get; set; }
        public bool ResultBold { get; set; }
        public byte ResultFontSize { get; set; }
        public Nullable<System.DateTime> ResultTime { get; set; }
        public bool SendTest { get; set; }
        public string SIDRef { get; set; }
        public bool Special { get; set; }
        public string TestID { get; set; }
        public byte TestNameFontSize { get; set; }
        public string Unit1 { get; set; }
        public int Validity { get; set; }
        public bool NotPrint { get; set; }
        public int PrintType { get; set; }
        public int PrintGroup { get; set; }
        public Nullable<System.DateTime> ValidTime { get; set; }
    
        public virtual tbl_Patient tbl_Patient { get; set; }
    }
}
