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
    
    public partial class Quote
    {
        public decimal Id { get; set; }
        public Nullable<decimal> IdAccount { get; set; }
        public Nullable<decimal> IdContract { get; set; }
        public string MoTa { get; set; }
        public string TenBaoGia { get; set; }
        public Nullable<decimal> IdLoaiQuote { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual TuDien TuDien { get; set; }
    }
}
