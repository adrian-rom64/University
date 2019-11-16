using System;
using System.Collections.Generic;
using System.Text;

namespace Uni
{
    abstract class Osoba
    {
        protected string Imie;
        protected string Nazwisko;
        protected DateTime DataUrodzenia;
        protected ulong PESEL;
        protected int NumerTelefonu;
        protected string Email;

        protected Osoba(string Imie, string Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
        }
        public void UzupelnijDane(ulong PESEL, string DataUrodzenia, int NumerTelefonu, string Email, )
        {
            this.PESEL = PESEL;
            this.DataUrodzenia = DateTime.Parse(DataUrodzenia);
            this.NumerTelefonu = NumerTelefonu;
            this.Email = Email;
        }
        public override string ToString()
        {
            return $"{Imie} {Nazwisko} - {this.GetType().Name}";
        }
    }
}
