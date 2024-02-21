using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5_007
{
	class Ford :Car
	{
		private int year;
		private int manufacturerDiscount;

		// Constructor
		public Ford(decimal speed, double regularPrice, string color, int year, int manufacturerDiscount)
			: base(speed, regularPrice, color)
		{
			this.year = year;
			this.manufacturerDiscount = manufacturerDiscount;
		}

		// Method
		public override double GetSalePrice()
		{
			double salePrice = regularPrice;
			return salePrice - manufacturerDiscount;
		}
	}
}
