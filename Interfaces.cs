using System;

namespace Uni
{
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