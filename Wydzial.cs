using System;

namespace Uni
{
	class Wydzial
  	{
		public string Nazwa;
		public Nauczyciel Dziekan;

		public Wydzial(string Nazwa, Nauczyciel Dziekan)
		{
			this.Nazwa = Nazwa;
			this.Dziekan = Dziekan;
		}
  	}
}