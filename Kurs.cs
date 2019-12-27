using System;

namespace Uni
{
	class Kurs
	{
		public string Nazwa;
		public float ECTS;

		public Kurs(string nazwa)
		{
			this.Nazwa = nazwa;
		}
		public void getECTS()
		{
			Console.WriteLine($"Kurs {this.Nazwa} jest warty {this.ECTS} punktow ECTS");
		}
	}
}