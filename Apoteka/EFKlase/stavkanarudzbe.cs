namespace Apoteka.EFKlase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apoteka.stavkanarudzbe")]
    public partial class stavkanarudzbe
    {
        public int kolicina { get; set; }

        public decimal iznos { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idNarudzbe { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLijeka { get; set; }

        public bool obrisano { get; set; }

        public virtual lijek lijek { get; set; }

        public virtual narudzba narudzba { get; set; }
    }
}
