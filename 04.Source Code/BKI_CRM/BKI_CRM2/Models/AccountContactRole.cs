//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BKI_CRM2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountContactRole
    {
        public decimal Id { get; set; }
        public Nullable<decimal> IdAccount { get; set; }
        public Nullable<decimal> IdContact { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
