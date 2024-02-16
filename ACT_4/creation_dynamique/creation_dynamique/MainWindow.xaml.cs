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

namespace creation_dynamique
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void NewGrid()
        {
            ColumnDefinition[] C = new ColumnDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                C[i] = new ColumnDefinition();
            }
            for (int i = 0; i < 3; i++)
            {
                G.ColumnDefinitions.Add(C[i]);
            }
            RowDefinition[] R = new RowDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                R[i] = new RowDefinition();
            }
            for (int i = 0; i < 3; i++)
            {
                G.RowDefinitions.Add(R[i]);
            }

            TextBlock tB = new TextBlock();          
            tB.Text = "Bla-bla-bla-bla-bla"; 
            tB.Foreground = Brushes.Red;
            tB.Background = Brushes.Yellow;
            tB.HorizontalAlignment = HorizontalAlignment.Left;
            tB.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetColumn(tB, 0);
            Grid.SetRow(tB, 0);
            Grid.SetRowSpan(tB, 3);
            G.Children.Add(tB);

            Button[] Btn = new Button[3];
            for (int i = 0; i < 3; i++)
            {
                Btn[i] = new Button();
            }
            for (int i = 0; i < 3; i++)
            {
                Grid.SetRow(Btn[i], 1);
                Grid.SetColumn(Btn[i], 0 + i);
                G.Children.Add(Btn[i]);
            }
            
            StackPanel panel = new StackPanel();
            TextBlock tBp = new TextBlock();
            tBp.Text = "infos :";
            tBp.VerticalAlignment = VerticalAlignment.Top;
            tBp.Background = Brushes.Yellow;

        }

    }
}
