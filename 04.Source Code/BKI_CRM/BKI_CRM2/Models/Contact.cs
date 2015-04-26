
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
    
public partial class Contact
{

    public Contact()
    {

        this.AccountContactRole = new HashSet<AccountContactRole>();

        this.ContactStateChange = new HashSet<ContactStateChange>();

        this.ContractContactRole = new HashSet<ContractContactRole>();

        this.Task = new HashSet<Task>();

        this.UserContactRole = new HashSet<UserContactRole>();

    }


    public decimal Id { get; set; }

    public string Ho { get; set; }

    public string Ten { get; set; }

    public string DiaChi { get; set; }

    public Nullable<bool> GioiTinh { get; set; }

    public string Image { get; set; }

    public string Facebook { get; set; }

    public string Skype { get; set; }

    public Nullable<System.DateTime> NgaySinh { get; set; }

    public string Sdt01 { get; set; }

    public string Sdt02 { get; set; }

    public string MaSoThue { get; set; }

    public string SoTaiKhoan { get; set; }

    public string Website { get; set; }

    public string Email { get; set; }

    public Nullable<System.DateTime> HanKhachHang { get; set; }

    public Nullable<decimal> IdLoaiKhachHang { get; set; }



    public virtual ICollection<AccountContactRole> AccountContactRole { get; set; }

    public virtual ICollection<ContactStateChange> ContactStateChange { get; set; }

    public virtual ICollection<ContractContactRole> ContractContactRole { get; set; }

    public virtual ICollection<Task> Task { get; set; }

    public virtual ICollection<UserContactRole> UserContactRole { get; set; }

}

}
