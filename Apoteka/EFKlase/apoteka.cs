namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.apoteka")]
    public partial class apoteka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public apoteka()
        {
            lijeks = new HashSet<lijek>();
            sertifikats = new HashSet<sertifikat>();
        }

        [Key]
        public int idApoteke { get; set; }

        [Required]
        [StringLength(50)]
        public string nazivApoteke { get; set; }

        [Required]
        [StringLength(100)]
        public string adresa { get; set; }

        [Required]
        [StringLength(100)]
        public string telefon { get; set; }

        [StringLength(80)]
        public string email { get; set; }

        [StringLength(80)]
        public string webSajt { get; set; }

        [Column(TypeName = "date")]
        public DateTime datumOsnivanja { get; set; }

        public bool dezurnaApoteka { get; set; }

        [StringLength(100)]
        public string radnoVrijeme { get; set; }

        public int idMjesta { get; set; }

        public virtual mjesto mjesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lijek> lijeks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sertifikat> sertifikats { get; set; }
    }
}
