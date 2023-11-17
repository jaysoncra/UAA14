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

namespace EX_WPF_OBJET____EVENTS
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            BtnC.MouseEnter += new MouseEventHandler(SurvolBouton);
            BtnC.MouseLeave += new MouseEventHandler(SurvolBouton);
            

        }
        private bool EstEntier (string texteUser)
        {

            int num;

            if (int.TryParse(texteUser, out num))
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public void SurvolBouton(object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Hidden;
            BtnV.Background = Brushes.Red;
        }
    }
}
