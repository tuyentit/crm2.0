
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
    
public partial class Account
{

    public Account()
    {

        this.AccountContactRole = new HashSet<AccountContactRole>();

        this.Contract = new HashSet<Contract>();

        this.Order = new HashSet<Order>();

        this.Task = new HashSet<Task>();

    }


    public decimal Id { get; set; }

    public string AccountName { get; set; }

    public string DiaChi { get; set; }

    public string Sdt01 { get; set; }

    public string Sdt02 { get; set; }

    public Nullable<decimal> IdAccountType { get; set; }



    public virtual TuDien TuDien { get; set; }

    public virtual ICollection<AccountContactRole> AccountContactRole { get; set; }

    public virtual ICollection<Contract> Contract { get; set; }

    public virtual ICollection<Order> Order { get; set; }

    public virtual ICollection<Task> Task { get; set; }

}

}
