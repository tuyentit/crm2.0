
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
    
public partial class User
{

    public User()
    {

        this.ContactStateChange = new HashSet<ContactStateChange>();

        this.Task = new HashSet<Task>();

        this.UserContactRole = new HashSet<UserContactRole>();

    }


    public decimal Id { get; set; }

    public Nullable<decimal> IdUserGroup { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public Nullable<decimal> IdParentUser { get; set; }

    public Nullable<decimal> IdCompany { get; set; }

    public string HoNhanVien { get; set; }

    public string TenNhanVien { get; set; }

    public string Sdt01 { get; set; }

    public string Sdt02 { get; set; }

    public string Image { get; set; }

    public string Email { get; set; }

    public Nullable<bool> IsActive { get; set; }

    public Nullable<decimal> IdLoaiUser { get; set; }



    public virtual Company Company { get; set; }

    public virtual ICollection<ContactStateChange> ContactStateChange { get; set; }

    public virtual ICollection<Task> Task { get; set; }

    public virtual UserGroup UserGroup { get; set; }

    public virtual ICollection<UserContactRole> UserContactRole { get; set; }

}

}
