namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.racun")]
    public partial class racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public racun()
        {
            stavkaracunas = new HashSet<stavkaracuna>();
        }

        [Key]
        public int idRacuna { get; set; }

        [Column(TypeName = "date")]
        public DateTime datumKreiranja { get; set; }

        public decimal ukupanIznos { get; set; }

        public bool obrisano { get; set; }

        public int idZaposlenog { get; set; }

        public virtual zaposleni zaposleni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavkaracuna> stavkaracunas { get; set; }
    }
}
