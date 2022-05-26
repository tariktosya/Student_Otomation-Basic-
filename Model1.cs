using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VtysOdev
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tBolum> tBolum { get; set; }
        public virtual DbSet<tDers> tDers { get; set; }
        public virtual DbSet<tFakulte> tFakulte { get; set; }
        public virtual DbSet<tOgrenci> tOgrenci { get; set; }
        public virtual DbSet<tOgrenciDers> tOgrenciDers { get; set; }

        public virtual DbSet<tHoca> tHoca { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tBolum>()
                .Property(e => e.bolumAd)
                .IsFixedLength();

            modelBuilder.Entity<tDers>()
                .Property(e => e.dersAD)
                .IsFixedLength();

            modelBuilder.Entity<tFakulte>()
                .Property(e => e.fakulteAd)
                .IsFixedLength();

            modelBuilder.Entity<tOgrenci>()
                .Property(e => e.ad)
                .IsFixedLength();

            modelBuilder.Entity<tOgrenci>()
                .Property(e => e.soyad)
                .IsFixedLength();

            modelBuilder.Entity<tOgrenciDers>()
                .Property(e => e.yil)
                .IsFixedLength();

            modelBuilder.Entity<tOgrenciDers>()
                .Property(e => e.yariyil)
                .IsFixedLength();
            modelBuilder.Entity<tHoca>()
                .Property(e => e.hocaAD)
                .IsFixedLength();
            modelBuilder.Entity<tHoca>()
                .Property(e => e.hocaSoyad)
                .IsFixedLength();
        }
    }
}
