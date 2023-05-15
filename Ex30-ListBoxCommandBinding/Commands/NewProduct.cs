using Ex30_ListBoxCommandBinding.Models;
using Ex30_ListBoxCommandBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex30_ListBoxCommandBinding.Commands
{
    public class NewProduct : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return true; 
        }

        public void Execute(object? parameter)
        {
            if(parameter is MainViewModel mvm) {

                // Add a new default product to productRepo
                ProductRepo productRepo = new ProductRepo();
                Product newProduct = new Product("New Product", 0.0);
                productRepo.Products.Add(newProduct);

                // Add a new default product to productViewModel
                ProductViewModel productViewModel = new ProductViewModel(newProduct);
                mvm.ProductsVM.Add(productViewModel);
                
            }
        }

    }
}
