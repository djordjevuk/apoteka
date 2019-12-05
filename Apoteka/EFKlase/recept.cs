namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.recept")]
    public partial class recept
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public recept()
        {
            stavkaracunas = new HashSet<stavkaracuna>();
        }

        [Key]
        public int idRecepta { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(13)]
        public string jmbg { get; set; }

        [Required]
        [StringLength(75)]
        public string pacijent { get; set; }

        [Required]
        [StringLength(60)]
        public string adresa { get; set; }

        [Required]
        [StringLength(150)]
        public string izdatOdUstanove { get; set; }

        [Required]
        [StringLength(100)]
        public string izdatOdDoktora { get; set; }

        [Column(TypeName = "date")]
        public DateTime datumIzdavanja { get; set; }

        [Required]
        [StringLength(70)]
        public string nazivLijeka { get; set; }

        public int? kolicina { get; set; }

        [StringLength(150)]
        public string napomena { get; set; }

        public bool obrisano { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavkaracuna> stavkaracunas { get; set; }
    }
}
