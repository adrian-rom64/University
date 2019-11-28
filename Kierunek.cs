using System;
using System.Collections.Generic;

namespace Uni
{
	class Kierunek
	{
		public string Nazwa;
		public int IleStudentow;
		public List<Kurs> Kursy;

		public Kierunek(string Nazwa)
		{
			this.Nazwa = Nazwa;
			this.IleStudentow = 0;
			this.Kursy = new List<Kurs>();
		}
		public void DodajKursy(params Kurs[] kursy)
		{
			foreach(var item in kursy)
			{
				Kursy.Add(item);
				Console.WriteLine($"Na kierunku {this.Nazwa} dodano nowy kurs - {item.Nazwa}");
			}
		}
	}
}