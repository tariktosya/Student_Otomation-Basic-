namespace VtysOdev
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tOgrenciDers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? ogrenciID { get; set; }

        public int? dersID { get; set; }

        [StringLength(90)]
        public string yil { get; set; }

        [StringLength(90)]
        public string yariyil { get; set; }

        public double? vize { get; set; }

        public double? final { get; set; }

        public virtual tDers tDers { get; set; }

        public virtual tOgrenci tOgrenci { get; set; }
    }
}
