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

namespace Damier
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] Btn = new Button[10, 10];
        int compteur = 1;
        public MainWindow()
        {         
            InitializeComponent();
            NewGrid();
            Damier();
        }

        public void NewGrid()
        {
            ColumnDefinition[] C = new ColumnDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                C[i] = new ColumnDefinition();
            }
            for (int i = 0; i < 10; i++)
            {
                G.ColumnDefinitions.Add(C[i]);
            }

            RowDefinition[] R = new RowDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                R[i] = new RowDefinition();
            }
            for (int i = 0; i < 10; i++)
            {
                G.RowDefinitions.Add(R[i]);
            }
        }

        public void Damier()
        {         

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Btn[i, j] = new Button();
                    Grid.SetColumn(Btn[i, j], j);
                    Grid.SetRow(Btn[i, j], i);
                    Btn[i, j].Foreground = Brushes.Red;
                    Btn[i,j].Width = 65;
                    Btn[i,j].Height = 65;                   
                    Btn[i,j].Content = compteur;
                    if ((i+j)%2 == 0)
                    {
                        Btn[i, j].Background = Brushes.White;
                    }
                    else
                    {
                        Btn[i,j].Background = Brushes.Black;
                    }
                    compteur++;
                    G.Children.Add(Btn[i,j]);
                }
            }
        }
    }
}
