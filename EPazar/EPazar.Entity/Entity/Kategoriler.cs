﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class Kategoriler : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; }
        public int AnaKategoriId { get; set; }
        public string Ad { get; set; }
    }
}