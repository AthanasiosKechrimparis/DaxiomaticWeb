//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DaxiomaticWebPage.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class DaxUserData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaxUserData()
        {
            this.DaxBreakWeight = new HashSet<DaxBreakWeight>();
            this.DaxCompanyWeight = new HashSet<DaxCompanyWeight>();
            this.DaxEmailWeight = new HashSet<DaxEmailWeight>();
            this.DaxInputData = new HashSet<DaxInputData>();
            this.DaxMeetingWeight = new HashSet<DaxMeetingWeight>();
            this.DaxPhoneWeight = new HashSet<DaxPhoneWeight>();
            this.DaxTaskWeight = new HashSet<DaxTaskWeight>();
            this.DayOfWeekWeight = new HashSet<DayOfWeekWeight>();
        }
    
        public int ID { get; set; }
        public string UserID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxBreakWeight> DaxBreakWeight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxCompanyWeight> DaxCompanyWeight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxEmailWeight> DaxEmailWeight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxInputData> DaxInputData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxMeetingWeight> DaxMeetingWeight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxPhoneWeight> DaxPhoneWeight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxTaskWeight> DaxTaskWeight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DayOfWeekWeight> DayOfWeekWeight { get; set; }
    }
}
