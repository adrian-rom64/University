using System;
using System.Collections.Generic;

namespace Uni
{
    enum StopienWyksztalcenia
    {
        Inzynier,
        Magister,
        Doktor,
        Profesor
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Scenariusz 1 - nowy student
            var student = new Student("Adrian", "Romanowski");
            var dziekan = new Nauczyciel("Henryk", "Drzewo", StopienWyksztalcenia.Profesor);
            var wydzialInformatyki = new Wydzial("Wydzial Informatyki", dziekan);
            wydzialInformatyki.dziekanat = new Dziekanat(8,16, wydzialInformatyki);
            var kierunek = new Kierunek("Informatyka");
            wydzialInformatyki.DodajNowyKierunek(kierunek);
            kierunek.DodajKursy(new Kurs("Matematyka dyskretna"), new Kurs("Bazy Danych"));
            wydzialInformatyki.dziekanat.DodajStudenta(student, kierunek);
            Console.WriteLine(student);
            student.UzupelnijDane(96052702881, "1996-01-02", 639471493, "adrian@gmail.com");
            Console.WriteLine(student.PobierzDane());
            wydzialInformatyki.dziekanat.MigracjaDanych();

        }
    }
}
