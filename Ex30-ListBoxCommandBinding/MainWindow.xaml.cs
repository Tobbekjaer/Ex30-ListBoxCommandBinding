using Ex30_ListBoxCommandBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex30_ListBoxCommandBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = mvm;

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBox.SelectedItem != null) {
                mvm.UpdateSelectedProduct();
            }
            else {

            }
           
        }
    }
}
