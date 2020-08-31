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
using System.Windows.Shapes;
using deneme.Models;
using deneme.Services;
using deneme.Views;

namespace deneme
{
    /// <summary>
    /// denemedd.xaml etkileşim mantığı
    /// </summary>
    public partial class denemedd : Window
    {
        Services.Services services = new Services.Services();

        public denemedd()
        {
            InitializeComponent();

            var deneme1 = services.UserComRepository();
            dtGridDeneme.ItemsSource = deneme1;
        }
    }
}
