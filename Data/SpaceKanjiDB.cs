﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SpaceKanjiDB : DbContext
    {
        public DbSet<Kanji> Kanjis { get; set; }
    }
}
