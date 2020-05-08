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
using ConnectedDemo.LIB.Entities;
using ConnectedDemo.LIB.Services;

namespace ConnectedDemo.WPF
{
    /// <summary>
    /// Interaction logic for winSoorten.xaml
    /// </summary>
    public partial class winSoorten : Window
    {
        public bool reload = false;
        public winSoorten()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void VulLstSoorten()
        {

        }
        private void lstSoorten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btnSaveNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSaveCurrent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteCurrent_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
