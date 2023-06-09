﻿using Ex30_ListBoxCommandBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_ListBoxCommandBinding.ViewModels
{
    public class ProductViewModel
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

        public ProductViewModel(Product product)
        {
            _name = product.Name;
            _price = product.Price;
        }




    }
}
