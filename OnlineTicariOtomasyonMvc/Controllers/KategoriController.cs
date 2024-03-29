﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicariOtomasyonMvc.Models.Siniflar;
using PagedList;

namespace OnlineTicariOtomasyonMvc.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori

        Context context = new Context();

        public ActionResult Index(int sayfa = 1)
        {
            ViewBag.MainHeader = "Ana Sayfa";
            ViewBag.MainHeaderUrl = "/Dashboard/Index";
            ViewBag.SubHeader = "Kategoriler";

            var degerler = context.Kategoris.ToList().ToPagedList(sayfa, 5);
            return View(degerler);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            ViewBag.MainHeader = "Kategoriler";
            ViewBag.MainHeaderUrl = "/Kategori/Index";
            ViewBag.SubHeader = "Kategori Ekleme Sayfası";

            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori kategori)
        {
            ViewBag.MainHeader = "Kategoriler";
            ViewBag.MainHeaderUrl = "/Kategori/Index";
            ViewBag.SubHeader = "Kategori Ekleme Sayfası";

            context.Kategoris.Add(kategori);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var katerogi = context.Kategoris.Find(id);
            context.Kategoris.Remove(katerogi);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult KategoriGuncelle(int id)
        {
            ViewBag.MainHeader = "Kategoriler";
            ViewBag.MainHeaderUrl = "/Kategori/Index";
            ViewBag.SubHeader = "Kategori Güncelleme Sayfası";

            var kategori = context.Kategoris.Find(id);
            return View(kategori);
        }

        [HttpPost]
        public ActionResult KategoriGuncelle(Kategori kategori)
        {
            ViewBag.MainHeader = "Kategoriler";
            ViewBag.MainHeaderUrl = "/Kategori/Index";
            ViewBag.SubHeader = "Kategori Güncelleme Sayfası";

            var GKategori = context.Kategoris.Find(kategori.KategoriID);
            GKategori.KategoriAd = kategori.KategoriAd;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}