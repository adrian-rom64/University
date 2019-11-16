﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uni
{
    class Pracownik : Osoba
    {
        private string Stanowisko;
        private Pracownik Przelozony;
        private bool JestZatrudniony;
        private Decimal Pensja;

        public Pracownik(string ImieNazwisko) : base(ImieNazwisko)
        {
            this.JestZatrudniony = false;
        }
        public void Zatrudnij(string Stanowisko, float Pensja, Pracownik Przelozony)
        {
            this.Stanowisko = Stanowisko;
            this.Pensja = new decimal(Pensja);
            this.Przelozony = Przelozony;
            this.JestZatrudniony = true;
        }
        public void Zwolnij()
        {
            this.JestZatrudniony = false;
        }
    }
}
