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
    
    public partial class tbl_Reagent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Reagent()
        {
            this.tbl_TestCode_Reagent = new HashSet<tbl_TestCode_Reagent>();
        }
    
        public string ReagentID { get; set; }
        public string QuickCode { get; set; }
        public string ReagentName { get; set; }
        public Nullable<decimal> PackageSize { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }
        public string UserI { get; set; }
        public string UserU { get; set; }
        public Nullable<System.DateTime> Intime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TestCode_Reagent> tbl_TestCode_Reagent { get; set; }
    }
}