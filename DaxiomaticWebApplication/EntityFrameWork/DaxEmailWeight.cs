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
    
    public partial class DaxEmailWeight
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<int> WeightNumber { get; set; }
        public Nullable<int> SendCat { get; set; }
        public Nullable<int> ReceivedCat { get; set; }
    
        public virtual DaxEmailReceivedCategories DaxEmailReceivedCategories { get; set; }
        public virtual DaxEmailSendCategories DaxEmailSendCategories { get; set; }
        public virtual DaxUserData DaxUserData { get; set; }
    }
}
