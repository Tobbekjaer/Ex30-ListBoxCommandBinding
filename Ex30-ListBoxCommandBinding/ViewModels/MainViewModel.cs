using Ex30_ListBoxCommandBinding.Commands;
using Ex30_ListBoxCommandBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex30_ListBoxCommandBinding.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
		private ProductRepo productRepo = new ProductRepo();

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;

            if (propertyChanged != null) 
            { 
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<ProductViewModel> ProductsVM { get; set; }
        public ProductViewModel SelectedProduct { get; set; }

        public MainViewModel()
		{
			ProductsVM = new ObservableCollection<ProductViewModel>();
			foreach(Product product in productRepo.GetAll()) {
				ProductViewModel newProduct = new ProductViewModel(product);
				ProductsVM.Add(newProduct);
			}
		}

        public void UpdateSelectedProduct()
        {
            OnPropertyChanged("SelectedProduct");
        }

        public ICommand NewProduct { get; set; } = new NewProduct();

        public ICommand DeleteProduct { get; set;} = new DeleteProduct();
       



    }
}
