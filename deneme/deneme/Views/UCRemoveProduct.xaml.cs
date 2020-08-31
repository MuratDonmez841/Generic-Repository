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
using deneme.Models;
using deneme.Services;
namespace deneme.Views
{

    public partial class UCRemoveProduct : UserControl
    {
        Services.Services services = new Services.Services();
        int? id;
        public UCRemoveProduct(int? ID)
        {
            InitializeComponent();

            id = ID;
            getlists();
        }
        public void getlists() {
            var lists = services.getView(id);
            dataGridDelProduct.ItemsSource =lists;

        }
        private void DataGridDelProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var row = (vProducts)dataGridDelProduct.SelectedItem;
            if (MessageBox.Show(""+row.Name+" Adlı Öğeyi Silmek İstiyor Musunuz?","Uyarı!",MessageBoxButton.YesNoCancel)==MessageBoxResult.Yes)
            {
                services.DelProduct(row.ID);
                getlists();
                MessageBox.Show("Öğe Silindi!");
            }
            else
            {

            }
        }

        private void DataGridDelProduct_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString()=="CompanyName")
            {
                e.Cancel = true;
            }
        }
    }
}
