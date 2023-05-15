using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_ListBoxCommandBinding.Models
{
    public class ProductRepo
    {
		private List<Product> _products;

		public List<Product> Products
		{
			get { return _products; }
			set { _products = value; }
		}

		public ProductRepo() 
		{
			_products = new List<Product>();
			InitializeProducts();
		}

		private void InitializeProducts()
		{
			Products.Add(new Product("Apple", 7.95));
			Products.Add(new Product("Orange", 5.50));
            Products.Add(new Product("Banana", 8.25));
        }

		public List<Product> GetAll()
		{
			return _products;
		}

		
    }
}
