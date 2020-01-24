using System;

namespace Uni
{
    static class Scenariusz
    {
        static public void Play()
        {
            // Scenariusz 1 - nowy student
            var student = new Student("Adrian", "Romanowski");
            var dziekan = new Nauczyciel("Henryk", "Drzewo", StopienWyksztalcenia.Profesor);
            var wydzialInformatyki = new Wydzial("Wydzial Informatyki", dziekan, "Ksiezycowa 1");
            wydzialInformatyki.dziekanat = new Dziekanat(8,16, wydzialInformatyki);
            var kierunek = new Kierunek("Informatyka");
            wydzialInformatyki.DodajNowyKierunek(kierunek);
            kierunek.DodajKursy(new Kurs("Matematyka dyskretna"), new Kurs("Bazy Danych"));
            wydzialInformatyki.dziekanat.DodajStudenta(student, kierunek);
            student.UzupelnijDane(96052702881, "1996-01-02", 639471493, "adrian@gmail.com");
            // Console.WriteLine(student.PobierzDane());
            // wydzialInformatyki.dziekanat.MigracjaDanych();

            // Scenariusz 2 - Zatrudnij, zaplac i zwolnij
            var p1 = new Pracownik("Anna", "Korzen");
            p1.Zatrudnij("Szatniarz", 2000, dziekan);
            var p2 = new Nauczyciel("Ahmed", "Trzytysiace", StopienWyksztalcenia.Doktor);
            p2.Zatrudnij("Nauczyciel", 5000, dziekan);
            p1.Zwolnij();
            p2.Zwolnij();

            // Scenariusz 3 - koniec studiow
            kierunek.Kursy[0].getECTS();
            kierunek.getECTS();
            student.SkonczStudia(); 
        }
    }
}