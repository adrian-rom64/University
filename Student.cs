using System;
using System.Collections.Generic;
using System.Text;

namespace Uni
{
    class Student : Osoba
    {
        private static int IloscStudentow;
        private int NumerIndeksu;
        private float Srednia;
        private bool JestAbsolwentem;
        private StopienWyksztalcenia Stopien;

        public Student(string Imie, string Nazwisko) : base(Imie, Nazwisko)
        {
            this.NumerIndeksu = IloscStudentow + 10001;
            IloscStudentow += 1;
        }
    }
}
