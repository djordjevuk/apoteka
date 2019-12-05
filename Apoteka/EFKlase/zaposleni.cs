namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.zaposleni")]
    public partial class zaposleni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zaposleni()
        {
            fakturas = new HashSet<faktura>();
            narudzbas = new HashSet<narudzba>();
            racuns = new HashSet<racun>();
        }

        [Key]
        public int idZaposlenog { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(13)]
        public string jmbg { get; set; }

        [Required]
        [StringLength(40)]
        public string ime { get; set; }

        [Required]
        [StringLength(40)]
        public string prezime { get; set; }

        [Required]
        [StringLength(100)]
        public string adresa { get; set; }

        [StringLength(100)]
        public string telefon { get; set; }

        [StringLength(80)]
        public string email { get; set; }

        [Required]
        [StringLength(40)]
        public string strucnaSprema { get; set; }

        [StringLength(50)]
        public string farmaceutskoZvanje { get; set; }

        public bool sefApoteke { get; set; }

        [StringLength(150)]
        public string opisPosla { get; set; }

        [Required]
        [StringLength(45)]
        public string korisnickoIme { get; set; }

        [Required]
        [StringLength(64)]
        public string lozinka { get; set; }

        public int uloga { get; set; }

        public bool obrisano { get; set; }

        public bool aktivan { get; set; }

        public int idMjesta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<faktura> fakturas { get; set; }

        public virtual mjesto mjesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<narudzba> narudzbas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<racun> racuns { get; set; }
    }
}
