//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DaxiomaticWebApplication.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class DaxNrPhoneCallsCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaxNrPhoneCallsCategory()
        {
            this.DaxPhoneImpacts = new HashSet<DaxPhoneImpacts>();
            this.DaxPhoneWeight = new HashSet<DaxPhoneWeight>();
        }
    
        public int ID { get; set; }
        public string NumberOfCalls { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxPhoneImpacts> DaxPhoneImpacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxPhoneWeight> DaxPhoneWeight { get; set; }
    }
}
