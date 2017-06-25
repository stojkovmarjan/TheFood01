using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TheFood01.Models;

namespace TheFood01.DataAcess
{
    public class FoodDBContext: DbContext
    {
        public DbSet<Artikal> Artikli { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikal>().ToTable("TblArtikli");
            base.OnModelCreating(modelBuilder);
        }

    }
}