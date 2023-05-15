using Ex30_ListBoxCommandBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex30_ListBoxCommandBinding.Commands
{
    public class DeleteProduct : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            bool result = false;
            if(parameter is MainViewModel mvm) {
               if(mvm.SelectedProduct != null) {
                    result = true;
                }
            }
            return result;
        }

        public void Execute(object? parameter)
        {
            if (parameter is MainViewModel mvm) {
                mvm.ProductsVM.Remove(mvm.SelectedProduct);
            }
        }


    }
}
