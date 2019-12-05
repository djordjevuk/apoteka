namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.faktura")]
    public partial class faktura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public faktura()
        {
            narudzbas = new HashSet<narudzba>();
        }

        [Key]
        public int idFakture { get; set; }

        [Required]
        [StringLength(30)]
        public string brojFakture { get; set; }

        [Column(TypeName = "date")]
        public DateTime datumIzdavanja { get; set; }

        [Required]
        [StringLength(80)]
        public string mjestoIzdavanja { get; set; }

        [Required]
        [StringLength(60)]
        public string nacinPlacanja { get; set; }

        public decimal ukupanIznos { get; set; }

        public bool obrisano { get; set; }

        public int idZaposlenog { get; set; }

        public virtual zaposleni zaposleni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<narudzba> narudzbas { get; set; }
    }
}
