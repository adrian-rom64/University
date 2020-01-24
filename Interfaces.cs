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
	interface IAddress
	{
		void PrintAddress();
	}
	interface IPayable
	{
		void Pay(Decimal salary);
	}
	interface IECTS
	{
		void getECTS();
	}

}