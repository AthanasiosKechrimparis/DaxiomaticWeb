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
    
    public partial class DaxDayImpacts
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Day { get; set; }
        public Nullable<int> Impact { get; set; }
    
        public virtual DaxLoginInfo DaxLoginInfo { get; set; }
    }
}
