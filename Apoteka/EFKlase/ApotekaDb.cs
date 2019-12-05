namespace Apoteka.EFKlase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApotekaDb : DbContext
    {
        public ApotekaDb()
            : base("name=ApotekaDb")
        {
        }

        public virtual DbSet<apoteka> apotekas { get; set; }
        public virtual DbSet<dobavljac> dobavljacs { get; set; }
        public virtual DbSet<faktura> fakturas { get; set; }
        public virtual DbSet<lijek> lijeks { get; set; }
        public virtual DbSet<mjesto> mjestoes { get; set; }
        public virtual DbSet<narudzba> narudzbas { get; set; }
        public virtual DbSet<racun> racuns { get; set; }
        public virtual DbSet<recept> recepts { get; set; }
        public virtual DbSet<sertifikat> sertifikats { get; set; }
        public virtual DbSet<stavkanarudzbe> stavkanarudzbes { get; set; }
        public virtual DbSet<stavkaracuna> stavkaracunas { get; set; }
        public virtual DbSet<zaposleni> zaposlenis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<apoteka>()
                .Property(e => e.nazivApoteke)
                .IsUnicode(false);

            modelBuilder.Entity<apoteka>()
                .Property(e => e.adresa)
                .IsUnicode(false);

            modelBuilder.Entity<apoteka>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<apoteka>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<apoteka>()
                .Property(e => e.webSajt)
                .IsUnicode(false);

            modelBuilder.Entity<apoteka>()
                .Property(e => e.radnoVrijeme)
                .IsUnicode(false);

            modelBuilder.Entity<apoteka>()
                .HasMany(e => e.lijeks)
                .WithRequired(e => e.apoteka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<apoteka>()
                .HasMany(e => e.sertifikats)
                .WithRequired(e => e.apoteka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dobavljac>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<dobavljac>()
                .Property(e => e.adresa)
                .IsUnicode(false);

            modelBuilder.Entity<dobavljac>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<dobavljac>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<dobavljac>()
                .Property(e => e.webSajt)
                .IsUnicode(false);

            modelBuilder.Entity<dobavljac>()
                .HasMany(e => e.narudzbas)
                .WithRequired(e => e.dobavljac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.brojFakture)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.mjestoIzdavanja)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.nacinPlacanja)
                .IsUnicode(false);

            modelBuilder.Entity<lijek>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<lijek>()
                .Property(e => e.proizvodjac)
                .IsUnicode(false);

            modelBuilder.Entity<lijek>()
                .Property(e => e.pakovanje)
                .IsUnicode(false);

            modelBuilder.Entity<lijek>()
                .Property(e => e.netoKolicina)
                .IsUnicode(false);

            modelBuilder.Entity<lijek>()
                .Property(e => e.namjena)
                .IsUnicode(false);

            modelBuilder.Entity<lijek>()
                .HasMany(e => e.stavkanarudzbes)
                .WithRequired(e => e.lijek)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lijek>()
                .HasMany(e => e.stavkaracunas)
                .WithRequired(e => e.lijek)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mjesto>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<mjesto>()
                .Property(e => e.drzava)
                .IsUnicode(false);

            modelBuilder.Entity<mjesto>()
                .HasMany(e => e.apotekas)
                .WithRequired(e => e.mjesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mjesto>()
                .HasMany(e => e.dobavljacs)
                .WithRequired(e => e.mjesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mjesto>()
                .HasMany(e => e.zaposlenis)
                .WithRequired(e => e.mjesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<narudzba>()
                .Property(e => e.brojNarudzbe)
                .IsUnicode(false);

            modelBuilder.Entity<narudzba>()
                .HasMany(e => e.stavkanarudzbes)
                .WithRequired(e => e.narudzba)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<racun>()
                .HasMany(e => e.stavkaracunas)
                .WithRequired(e => e.racun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<recept>()
                .Property(e => e.jmbg)
                .IsUnicode(false);

            modelBuilder.Entity<recept>()
                .Property(e => e.pacijent)
                .IsUnicode(false);

            modelBuilder.Entity<recept>()
                .Property(e => e.adresa)
                .IsUnicode(false);

            modelBuilder.Entity<recept>()
                .Property(e => e.izdatOdUstanove)
                .IsUnicode(false);

            modelBuilder.Entity<recept>()
                .Property(e => e.izdatOdDoktora)
                .IsUnicode(false);

            modelBuilder.Entity<recept>()
                .Property(e => e.nazivLijeka)
                .IsUnicode(false);

            modelBuilder.Entity<recept>()
                .Property(e => e.napomena)
                .IsUnicode(false);

            modelBuilder.Entity<sertifikat>()
                .Property(e => e.izdatOd)
                .IsUnicode(false);

            modelBuilder.Entity<sertifikat>()
                .Property(e => e.podrucjePrimjene)
                .IsUnicode(false);

            modelBuilder.Entity<sertifikat>()
                .Property(e => e.standard)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.jmbg)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.ime)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.prezime)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.adresa)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.strucnaSprema)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.farmaceutskoZvanje)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.opisPosla)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.korisnickoIme)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .HasMany(e => e.fakturas)
                .WithRequired(e => e.zaposleni)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zaposleni>()
                .HasMany(e => e.narudzbas)
                .WithRequired(e => e.zaposleni)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zaposleni>()
                .HasMany(e => e.racuns)
                .WithRequired(e => e.zaposleni)
                .WillCascadeOnDelete(false);
        }
    }
}
