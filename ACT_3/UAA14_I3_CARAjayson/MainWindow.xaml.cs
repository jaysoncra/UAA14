using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace UAA14_I3_CARAjayson
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnR.Click += new RoutedEventHandler(ClickC);
            BtnR.Click += new RoutedEventHandler(ClickR);
            TxB1.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxB2.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            RB1.Checked += new RoutedEventHandler(Operation);
            RB2.Checked += new RoutedEventHandler(Operation);

        }

        private bool EstEntier(string texteUser)
        {

            int num;

            if (int.TryParse(texteUser, out num) && texteUser == "1" && texteUser == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClickC(object sender, RoutedEventArgs e)
        {

        }

        public void ClickR(object sender, RoutedEventArgs e)
        {

        }

        public void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text) && e.Text != "-")
            {
                e.Handled = true;
            }
            else if (e.Text == "," || e.Text == "-")
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
            }
        }

        public void Operation(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
