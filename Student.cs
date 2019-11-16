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
        private string Stopien;

        public Student(string ImieNazwisko) : base(ImieNazwisko)
        {
            this.NumerIndeksu = IloscStudentow + 10001;
            IloscStudentow += 1;
        }
    }
}
