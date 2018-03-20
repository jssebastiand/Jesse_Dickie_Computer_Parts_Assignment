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

namespace send_to_mcT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CPUBTN_Click(object sender, RoutedEventArgs e)
        {
            IMGCPU.Visibility = Visibility.Visible;
            IMGPRO.Visibility = Visibility.Collapsed;
            IMGMB.Visibility = Visibility.Collapsed;    

        }

        private void MBBTN_Click(object sender, RoutedEventArgs e)
        {
            IMGMB.Visibility = Visibility.Visible;
            IMGPRO.Visibility = Visibility.Collapsed;
            IMGCPU.Visibility = Visibility.Collapsed;
        }

        private void PROBTN_Click(object sender, RoutedEventArgs e)
        {
            IMGPRO.Visibility = Visibility.Visible;
            MBBTN.Visibility = Visibility.Visible;
            IMGCPU.Visibility = Visibility.Collapsed;
        }

        private void CBTN_Click(object sender, RoutedEventArgs e)
        {
            Case.Visibility = Visibility.Visible;
            IMGCPU.Visibility = Visibility.Collapsed;
            IMGPRO.Visibility = Visibility.Collapsed;
            IMGMB.Visibility = Visibility.Collapsed;
        }
    }
}
