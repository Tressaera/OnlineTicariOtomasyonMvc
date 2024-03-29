﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMvc.Models.Siniflar
{
    public class UrunDetay
    {
        [Key]
        public int UrunDetayID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string UrunBilgi { get; set; }
    }
}