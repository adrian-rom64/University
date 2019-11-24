using System;
using System.Collections.Generic;
using System.Text;

namespace Uni
{
    class Nauczyciel : Pracownik
    {
        private StopienWyksztalcenia Stopien;

        public Nauczyciel(string Imie, string Nazwisko, StopienWyksztalcenia Stopien) : base(Imie, Nazwisko)
        {
            this.Stopien = Stopien;
        }

    }
}
