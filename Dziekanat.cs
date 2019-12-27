using System;
using System.Collections.Generic;

namespace Uni
{
	class Dziekanat : IAddress
	{
		public int OtwarteOd;
		public int OtwarteDo;
		public List<Pracownik> Pracownicy;
		public Wydzial wydzial;
		public Dziekanat(int OtwarteOd, int OtwarteDo, Wydzial wydzial)
		{
			this.OtwarteOd = OtwarteOd;
			this.OtwarteDo = OtwarteDo;
			this.Pracownicy = new List<Pracownik>();
			this.wydzial = wydzial;
		}
		public void DodajStudenta(Student student, Kierunek kierunek)
		{
			student.kierunek = kierunek;
			this.wydzial.Studenci.Add(student);
			Console.WriteLine($"Dziekanat na {this.wydzial.Nazwa} dodal nowego studenta na kierunku {student.kierunek.Nazwa}");
		}
		public void MigracjaDanych()
		{
			string animation = "|/-\\";
			int step = 3;
			int time = new Random().Next(50,120);
			Console.Write("Trwa Migracja Danych... [[[");
			for (int k = 0; k < time; k += 1) 
			{
				if (step == 3) step = 0;
				else step += 1;
				Console.Write($"\b\b{animation[step]}]");
				System.Threading.Thread.Sleep(100);
			}
			Console.Write("\b\bOK]\n");
		}
		public void PrintAddress()
		{
			Console.WriteLine(this.wydzial.Address);
		}
	}
}