namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.mjesto")]
    public partial class mjesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mjesto()
        {
            apotekas = new HashSet<apoteka>();
            dobavljacs = new HashSet<dobavljac>();
            zaposlenis = new HashSet<zaposleni>();
        }

        [Key]
        public int idMjesta { get; set; }

        public int brojPoste { get; set; }

        [Required]
        [StringLength(40)]
        public string naziv { get; set; }

        [Required]
        [StringLength(40)]
        public string drzava { get; set; }

        public bool obrisano { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<apoteka> apotekas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dobavljac> dobavljacs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zaposleni> zaposlenis { get; set; }
    }
}
