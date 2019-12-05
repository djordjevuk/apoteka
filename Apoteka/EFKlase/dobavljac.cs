namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.dobavljac")]
    public partial class dobavljac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dobavljac()
        {
            narudzbas = new HashSet<narudzba>();
        }

        [Key]
        public int idDobavljaca { get; set; }

        [Required]
        [StringLength(60)]
        public string naziv { get; set; }

        [Required]
        [StringLength(100)]
        public string adresa { get; set; }

        [StringLength(100)]
        public string telefon { get; set; }

        [StringLength(80)]
        public string email { get; set; }

        [StringLength(80)]
        public string webSajt { get; set; }

        public bool regKodALMS { get; set; }

        public bool obrisano { get; set; }

        public int idMjesta { get; set; }

        public virtual mjesto mjesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<narudzba> narudzbas { get; set; }
    }
}
