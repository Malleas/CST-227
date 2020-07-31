using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopGUI
{
	public class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public decimal Price { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		public Car(string make, string model, decimal price, int year, string color)
		{
			Make = make;
			Model = model;
			Price = price;
			Year = year;
			Color = color;
		}

		public Car() {
			Make = "Nothing yet";
			Model = "Nothing yet";
			Price = 0;
			Year = 0;
			Color = "Nothing yet";
		}

		public string Display
		{
			get {
				return string.Format("{0} {1} ${2} {3} {4}", Make, Model, Price, Year, Color); 
			}
		}
	}
}


