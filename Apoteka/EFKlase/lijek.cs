namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.lijek")]
    public partial class lijek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lijek()
        {
            stavkanarudzbes = new HashSet<stavkanarudzbe>();
            stavkaracunas = new HashSet<stavkaracuna>();
        }

        [Key]
        public int idLijeka { get; set; }

        [Required]
        [StringLength(70)]
        public string naziv { get; set; }

        [Required]
        [StringLength(70)]
        public string proizvodjac { get; set; }

        [Required]
        [StringLength(120)]
        public string pakovanje { get; set; }

        public bool izdavanjeNaRecept { get; set; }

        [Required]
        [StringLength(80)]
        public string netoKolicina { get; set; }

        public int kolicinaNaStanju { get; set; }

        public decimal nabavnaCijena { get; set; }

        public decimal prodajnaCijena { get; set; }

        [Column(TypeName = "date")]
        public DateTime dozvolaVaziOd { get; set; }

        [Column(TypeName = "date")]
        public DateTime dozvolaVaziDo { get; set; }

        [StringLength(600)]
        public string namjena { get; set; }

        public bool obrisano { get; set; }

        public int idApoteke { get; set; }

        public virtual apoteka apoteka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavkanarudzbe> stavkanarudzbes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavkaracuna> stavkaracunas { get; set; }
    }
}
