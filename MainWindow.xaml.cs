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

namespace u1_03_JesseComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object Processor { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void BtnClickMe_Click(object sender, RoutedEventArgs e)
        {
            Processor.Visibility = Visibility.Visible;
        }
        private void BtnClickMe2_Click(object sender, RoutedEventArgs e)
        {
            Content = "Motherboard";

        }
        private void BtnClickMe3_Click(object sender, RoutedEventArgs e)
        {
            Content = "CPU";
        }
        private void BtnClickMe4_Click(object sender, RoutedEventArgs e)
        {
            Content = "Memory";
        }
        private void BtnClickMe5_Click(object sender, RoutedEventArgs e)
        {
            Content = "Case";
        }
        private void BtnClickMe6_Click(object sender, RoutedEventArgs e)
            {
                Content = "UPS";
            }
        }
    }
 
