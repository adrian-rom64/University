using System;
using System.Collections.Generic;

namespace Uni
{
	class Dziekanat
	{
		public int OtwarteOd;
		public int OtwarteDo;
		public List<Pracownik> Pracownicy;
		public Dziekanat(int OtwarteOd, int OtwarteDo)
		{
			this.OtwarteOd = OtwarteOd;
			this.OtwarteDo = OtwarteDo;
			this.Pracownicy = new List<Pracownik>();
		}
	}
}