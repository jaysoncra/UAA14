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

namespace CE_UAA14WPF24Rattrapage_CARAjayson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ParaBandeLat.Visibility = Visibility.Hidden;
            
        }
        private void IsChecked(object sender, RoutedEventArgs e)
        {
            ParaBandeLat.Visibility = Visibility.Visible;     
        }

        private void IsUnchecked(object sender, RoutedEventArgs e)
        {
            ParaBandeLat.Visibility = Visibility.Hidden;
        }
        private void Click(object sender, RoutedEventArgs e)
        {

        }

        private void Enter(object sender, TouchEventArgs e)
        {

        }

        private void TextimputL(object sender, TextCompositionEventArgs e)
        {
        
        }

        private void TextimputC(object sender, TextCompositionEventArgs e)
        {

        }

        private void SoIsChecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
