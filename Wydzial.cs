using System;
using System.Collections.Generic;

namespace Uni
{
	class Wydzial : IAddress
  {
		public string Nazwa;
		public Nauczyciel Dziekan;
		public Dziekanat dziekanat;
		public List<Student> Studenci;
		public List<Kierunek> Kierunki;
		public string Address;

		public Wydzial(string Nazwa, Nauczyciel Dziekan, string address)
		{
			this.Nazwa = Nazwa;
			this.Dziekan = Dziekan;
			this.Studenci = new List<Student>();
			this.Kierunki = new List<Kierunek>();
			this.Address = address;
		}
		public void DodajNowyKierunek(Kierunek kierunek)
		{
			this.Kierunki.Add(kierunek);
			Console.WriteLine($"Na {this.Nazwa} dodano nowy kierunek - {kierunek.Nazwa}");
		}
		public void PrintAddress()
		{
			Console.WriteLine(this.Address);
		}
  }
}