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
            var student = new Student("Adrian", "Romanowski");
            var pracownik = new Pracownik("Maciek", "Kowalski");
            var nauczyciel = new Nauczyciel("Marlena", "Nowak", StopienWyksztalcenia.Magister);
            student.UzupelnijDane(96052702991, "1996-05-27", 456123965, "adrian@rom.com");
            pracownik.UzupelnijDane(78102378432, "1978-10-23", 438657432, "maciek@kow.com");
            nauczyciel.UzupelnijDane(86111198345, "1986-11-11", 761230564, "marlena@now.com");
            Console.WriteLine(student.PobierzDane());
            Console.WriteLine(nauczyciel.PobierzDane());
            Console.WriteLine(pracownik.PobierzDane());
        }
    }
}
