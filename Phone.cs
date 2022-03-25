using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PhoneStore
{
    public class Phone : IDevice
    {
		public Phone()
        {
			Console.WriteLine("Brand:");
			this.Brand = Console.ReadLine();
			Console.WriteLine("Model:");
			this.Model = Console.ReadLine();
			Console.WriteLine("Price:");
			double price = double.Parse(Console.ReadLine());
			if (price < 0)
				throw new Error(ErrorCode.InvalidPrice);
			this.Price = price;
		}

		[JsonConstructor]
		public Phone(string brand = "", string model = "", double price = 0)
		{
			this.Brand = brand;
			this.Model = model;
			if (price < 0)
				throw new Error(ErrorCode.InvalidPrice);
			this.Price = price;
		}

		public Phone(Phone other)
		{
			this.Brand = other.Brand;
			this.Model = other.Model;
			this.Price = other.Price;
		}

		public override string ToString()
		{
			return $"Phone: {Brand} {Model} {Price}$";
		}

		public string Brand { get; set; }
		public string Model { get; set; }
		public double Price { get; set; }
	}
}
