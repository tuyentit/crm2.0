
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
    
public partial class ContactState
{

    public ContactState()
    {

        this.Contact = new HashSet<Contact>();

        this.ContactStateChange = new HashSet<ContactStateChange>();

        this.ContactStateProcess = new HashSet<ContactStateProcess>();

        this.ContactStateProcess1 = new HashSet<ContactStateProcess>();

        this.ToBeConverted = new HashSet<ToBeConverted>();

    }


    public decimal Id { get; set; }

    public string MaTrangThai { get; set; }

    public string TenTrangThai { get; set; }

    public Nullable<decimal> IdCompany { get; set; }

    public string MoTa { get; set; }



    public virtual Company Company { get; set; }

    public virtual ICollection<Contact> Contact { get; set; }

    public virtual ICollection<ContactStateChange> ContactStateChange { get; set; }

    public virtual ICollection<ContactStateProcess> ContactStateProcess { get; set; }

    public virtual ICollection<ContactStateProcess> ContactStateProcess1 { get; set; }

    public virtual ICollection<ToBeConverted> ToBeConverted { get; set; }

}

}
