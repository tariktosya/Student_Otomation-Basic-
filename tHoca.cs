namespace VtysOdev
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tHoca")]
    public partial class tHoca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hocaID { get; set; }

        [StringLength(90)]
        public string hocaAD { get; set; }

        [StringLength(90)]
        public string hocaSoyad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDers> tDers { get; set; }
    }
}
