using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_ListBoxCommandBinding.Models
{
    public class Product
    {
		private string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private double _price;

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}

		public Product(string name, double price)
		{
			_name = name;
			_price = price;
		}



    }
}
