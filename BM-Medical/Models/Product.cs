﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Ürün Adı")]
        public string Ad { get; set; }
        public Category Category { get; set; }
        public byte[] Image { get; set; }
        [Range(1, int.MaxValue)]
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public string Aciklama { get; set; }
    }
}
