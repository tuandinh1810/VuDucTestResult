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
    
    public partial class tbl_InterfacePara
    {
        public string HostID { get; set; }
        public short PortID { get; set; }
        public string InstrumentID { get; set; }
        public string Settings { get; set; }
        public string RemoteIP { get; set; }
        public string RemotePort { get; set; }
        public Nullable<short> CommPort { get; set; }
        public System.Guid rowguid { get; set; }
    }
}