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
    
    public partial class tbl_0Config
    {
        public int AutoID { get; set; }
        public byte FontType { get; set; }
        public bool SharePrint { get; set; }
        public byte HisResult { get; set; }
        public bool AutoSID { get; set; }
        public byte AutoPrintTime { get; set; }
        public byte AutoValidTime { get; set; }
        public byte AutoFocusTime { get; set; }
        public byte AutoCalTime { get; set; }
        public byte AutoExportQCTime { get; set; }
        public byte AutoPrintMode { get; set; }
        public int PrintOutTimer { get; set; }
        public int PrintUnloadTimer { get; set; }
        public byte AutoOrderTimer { get; set; }
        public byte AutoUploadTimer { get; set; }
        public bool AutoUploadError { get; set; }
        public bool AutoUploadOverwrite { get; set; }
        public bool AutoUploadWriteLogIfOverWrite { get; set; }
        public byte AutoWarningUrgentTime { get; set; }
        public bool AutoWarningUrgent { get; set; }
        public System.DateTime CutDBDate { get; set; }
        public double SpecialTestPrice { get; set; }
        public double NormalTestPrice { get; set; }
        public string PathDatabase { get; set; }
        public string SmtpServer { get; set; }
        public string MailFrom { get; set; }
        public string AttachPath { get; set; }
        public string BodyMail { get; set; }
        public string UserMail { get; set; }
        public string PasswordMail { get; set; }
        public Nullable<System.DateTime> DMSUsed { get; set; }
        public bool PrintCate { get; set; }
        public bool SignPos { get; set; }
        public System.Guid rowguid { get; set; }
        public bool UseLogo { get; set; }
        public byte[] Logo { get; set; }
        public byte BIU { get; set; }
        public bool PrintInsName { get; set; }
        public string Version { get; set; }
        public string AcceptCom { get; set; }
    }
}
