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
    
    public partial class DaxLoginInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaxLoginInfo()
        {
            this.DaxDayImpacts = new HashSet<DaxDayImpacts>();
            this.DaxEmailImpacts = new HashSet<DaxEmailImpacts>();
            this.DaxMeetingImpacts = new HashSet<DaxMeetingImpacts>();
            this.DaxPhoneImpacts = new HashSet<DaxPhoneImpacts>();
            this.DaxTaskImpacts = new HashSet<DaxTaskImpacts>();
            this.DaxTimeOfDayImpacts = new HashSet<DaxTimeOfDayImpacts>();
            this.DaxWorkLocationImpacts = new HashSet<DaxWorkLocationImpacts>();
        }
    
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> UserLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxDayImpacts> DaxDayImpacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxEmailImpacts> DaxEmailImpacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxMeetingImpacts> DaxMeetingImpacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxPhoneImpacts> DaxPhoneImpacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxTaskImpacts> DaxTaskImpacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxTimeOfDayImpacts> DaxTimeOfDayImpacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaxWorkLocationImpacts> DaxWorkLocationImpacts { get; set; }
    }
}
