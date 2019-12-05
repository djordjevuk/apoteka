using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.EFKlase
{
    partial class mjesto
    {
        public override bool Equals(object obj)
        {
            var mjesto = obj as mjesto;
            return mjesto != null &&
                   idMjesta == mjesto.idMjesta;
        }

        public override int GetHashCode()
        {
            return -2079837536 + idMjesta.GetHashCode();
        }

        public override string ToString()
        {
            return brojPoste + ", " + naziv;
        }
    }

    partial class zaposleni
    {
        public override bool Equals(object obj)
        {
            var zaposleni = obj as zaposleni;
            return zaposleni != null &&
                   idZaposlenog == zaposleni.idZaposlenog;
        }

        public override int GetHashCode()
        {
            return 895368950 + idZaposlenog.GetHashCode();
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }
    }

    partial class lijek
    {
        public override bool Equals(object obj)
        {
            var lijek = obj as lijek;
            return lijek != null &&
                   idLijeka == lijek.idLijeka;
        }

        public override int GetHashCode()
        {
            return 895368950 + idLijeka.GetHashCode();
        }

        public override string ToString()
        {
            return naziv;
        }
    }

    partial class dobavljac
    {
        public override bool Equals(object obj)
        {
            var dobavljac = obj as dobavljac;
            return dobavljac != null &&
                   idDobavljaca == dobavljac.idDobavljaca;
        }

        public override int GetHashCode()
        {
            return -1016616869 + idDobavljaca.GetHashCode();
        }

        public override string ToString()
        {
            return naziv;
        }
    }
}
