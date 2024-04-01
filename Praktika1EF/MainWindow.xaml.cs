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

namespace Praktika1EF
{
    public partial class MainWindow : Window
    {
        private Praktika1Entities content = new Praktika1Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable.ItemsSource = content.Customers.ToList();
        }

        private void DirectorsButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable.ItemsSource = content.Directors.ToList();
        }

        private void PurchasesButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable.ItemsSource = content.Purchases.ToList();
        }

        private void StoreButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable.ItemsSource = content.Store.ToList();
        }
    }
}
