namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.narudzba")]
    public partial class narudzba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public narudzba()
        {
            stavkanarudzbes = new HashSet<stavkanarudzbe>();
        }

        [Key]
        public int idNarudzbe { get; set; }

        [Required]
        [StringLength(30)]
        public string brojNarudzbe { get; set; }

        [Column(TypeName = "date")]
        public DateTime datumKreiranja { get; set; }

        public decimal ukupanIznos { get; set; }

        public bool kompletirano { get; set; }

        public bool obrisano { get; set; }

        public int idZaposlenog { get; set; }

        public int idDobavljaca { get; set; }

        public int? idFakture { get; set; }

        public virtual dobavljac dobavljac { get; set; }

        public virtual faktura faktura { get; set; }

        public virtual zaposleni zaposleni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavkanarudzbe> stavkanarudzbes { get; set; }
    }
}
