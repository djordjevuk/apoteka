namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.sertifikat")]
    public partial class sertifikat
    {
        [Key]
        public int idSertifikata { get; set; }

        [Column(TypeName = "date")]
        public DateTime datumSertifikovanja { get; set; }

        [Required]
        [StringLength(150)]
        public string izdatOd { get; set; }

        [Required]
        [StringLength(400)]
        public string podrucjePrimjene { get; set; }

        [Required]
        [StringLength(20)]
        public string standard { get; set; }

        [Column(TypeName = "date")]
        public DateTime datumIsteka { get; set; }

        public bool obrisano { get; set; }

        public int idApoteke { get; set; }

        public virtual apoteka apoteka { get; set; }
    }
}
