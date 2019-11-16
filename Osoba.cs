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

        protected Osoba(string ImieNazwisko)
        {
            this.Imie = ImieNazwisko.Split(" ")[0];
            this.Nazwisko = ImieNazwisko.Split(" ")[1];
        }
        public void UzupelnijDane(ulong PESEL, string DataUrodzenia, int NumerTelefonu, string Email)
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
        public string PobierzDane()
        {
            string str = "";
            str += $"Imie: {Imie}\n";
            str += $"Nazwisko: {Nazwisko}\n";
            str += $"Data Urodzenia: {DataUrodzenia}\n";
            str += $"PESEL: {PESEL}\n";
            str += $"Nr Telefonu: {NumerTelefonu}\n";
            str += $"Email: {Email}\n";
            return str;
        }
    }
}
