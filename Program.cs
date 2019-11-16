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
            List<Student> test = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                var temp = new Student(Factory.Name());
                temp.UzupelnijDane(Factory.PESEL(), Factory.Birthday(), Factory.Phone(), Factory.Email());
                test.Add(temp);
            }
            foreach (var item in test)
            {
                Console.WriteLine(item.PobierzDane());
            }
        }
    }
}
