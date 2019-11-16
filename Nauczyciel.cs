using System;
using System.Collections.Generic;
using System.Text;

namespace Uni
{
    class Nauczyciel : Pracownik
    {
        private StopienWyksztalcenia Stopien;

        public Nauczyciel(string ImieNazwisko, StopienWyksztalcenia Stopien) : base(ImieNazwisko)
        {
            this.Stopien = Stopien;
        }

    }
}
