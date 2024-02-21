using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5_007
{
	 class Sedan:Car
	{
		private int length;

		// Constructor
		public Sedan(decimal speed, double regularPrice, string color, int length)
			: base(speed, regularPrice, color)
		{
			this.length = length;
		}

		// Method
		public override double GetSalePrice()
		{
			if (length > 20)
				return regularPrice * 0.95; // 5% discount
			else
				return regularPrice * 0.9; // 10% discount
		}
	}
}
