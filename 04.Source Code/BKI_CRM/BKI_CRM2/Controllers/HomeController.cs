﻿using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BKI_CRM2.Models;
using System.IO;
using OpenXMLExcel.SLExcelUtility;
using BKI_CRM2.Controllers;
using System.Net.Mail;
using System.Text;


namespace BKI_CRM2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CrmEntities v_model = new CrmEntities();
            List<List<Contact>> v_dm_kh = new List<List<Contact>>();
            List<TuDien> v_tu_dien = new List<TuDien>();
            List<Account> v_account = new List<Account>();
            List<ContactState> state = v_model.ContactState.OrderBy(x => x.Order).ToList<ContactState>();

            //  List<UserContactRole> v_us_ct = new List<UserContactRole>();
            var v_us_ct = v_model.UserContactRole.Where(o => o.IsActive == true).Select(o => o.IdContact).Distinct().ToList();

            List<User> v_us = new List<User>();
            v_us = v_model.User.ToList<User>();
            List<decimal> idus = new List<decimal>(); List<string> nameus = new List<string>();
            for (int i = 0; i < v_us.Count; i++)
            {
                idus.Add(v_us[i].Id); nameus.Add(v_us[i].HoNhanVien + " " + v_us[i].TenNhanVien);
            }
            List<Contact> v_ct = new List<Contact>();
            v_ct = v_model.Contact.ToList<Contact>();
            List<decimal> idct = new List<decimal>(); List<string> namect = new List<string>();
            for (int i = 0; i < v_ct.Count; i++)
            {
                idct.Add(v_ct[i].Id); namect.Add(v_ct[i].Ho + " " + v_ct[i].Ten);
            }

            for (int i = 0; i < state.Count; i++)
            {
                decimal temp = state[i].Id;
                v_dm_kh.Add(v_model.Contact.Where(x => x.IdTrangThaiHienTai == temp).ToList<Contact>());
            }
            decimal loaitd = -1; var temp2 = v_model.LoaiTuDien.FirstOrDefault(x => x.MaLoaiTuDien == "ContactType");
            if (temp2 != null) loaitd = temp2.Id;
            v_tu_dien = v_model.TuDien.Where(x => x.IdLoaiTuDien == loaitd).ToList<TuDien>();
            ViewBag.v_dm_kh = v_dm_kh;
            ViewBag.v_tu_dien = v_tu_dien;
            ViewBag.state = state;
            v_account = v_model.Account.ToList<Account>();
            ViewBag.v_account = v_account;
            ViewBag.idus = idus;
            ViewBag.nameus = nameus;
            ViewBag.idct = idct;
            ViewBag.namect = namect;
            ViewBag.v_us_ct = v_us_ct;
            return View();
        }
    }
}
