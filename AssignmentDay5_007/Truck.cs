using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5_007
{
     class Truck : Car
	{
		private int weight;

    // Constructor
    public Truck(decimal speed, double regularPrice, string color, int weight)
        : base(speed, regularPrice, color)
    {
        this.weight = weight;
    }

    // Method
    public override double GetSalePrice()
    {
        if (weight > 2000)
		    return regularPrice * 0.9; // 10% discount
        else
            return regularPrice * 0.8; // 20% discount
    }
	}
}
