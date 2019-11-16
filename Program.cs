using System;

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
            var test = new Student("Adrian", "Romanowski");
            Console.WriteLine(test);
        }
    }
}
