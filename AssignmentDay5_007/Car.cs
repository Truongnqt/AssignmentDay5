using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5_007
{
    abstract class Car : ICarPrice 
	{
		public decimal speed { get; set; }
		public double regularPrice { get; set; }
		public string color { get; set; }	
		//Constructor
		public Car() { }
		public Car(decimal speed, double regularPrice,string color) { 
		    this.speed = speed;	
			this.regularPrice = regularPrice;
			this.color = color;
		}
		public virtual double GetSalePrice()
		{
			return this.regularPrice;
		}
	}
}
