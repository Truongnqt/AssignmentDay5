using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5_007
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ICarPrice sedan = new Sedan(80, 59900, "Red", 22);
				ICarPrice ford1 = new Ford(70, 30000, "Blue", 2024, 1500);
				ICarPrice ford2 =  new Ford(80, 25000, "Green", 2024, 1800);
				ICarPrice truck1 = new Truck(50, 40000, "Black", 2000);
				ICarPrice truck2 = new Truck(55, 35000, "White", 1400);

				Console.WriteLine("Sedan Price(Sale): " + sedan.GetSalePrice());
				Console.WriteLine("Ford1  Price(Sale): " + ford1.GetSalePrice());
				Console.WriteLine("Ford2  Price(Sale): " + ford2.GetSalePrice());
				Console.WriteLine("Truck1  Price(Sale): " + truck1.GetSalePrice());
				Console.WriteLine("Truck2  Price(Sale): " + truck2.GetSalePrice());
			}
			catch ( Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
		}
	}
}
