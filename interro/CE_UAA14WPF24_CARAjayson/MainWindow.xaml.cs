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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tp.Visibility = Visibility.Hidden;
            RbSolitaire.Click += new RoutedEventHandler(RbSolitaire_Click);
            RbMarelle.Click += new RoutedEventHandler(RbMarelle_Click);
            RbBandeL.Click += new RoutedEventHandler(RbBandeL_Click);
            TxtBxLignes.PreviewTextInput += new TextCompositionEventHandler(TxtBLignes_PreviewTextInput);
            TxtBxColonnes.PreviewTextInput += new TextCompositionEventHandler(TxtBColonnes_PreviewTextInput);
            //TxtBMessage.DataContextChanged += new DependencyPropertyChangedEventHandler(TxtBMessage_DataContextChanged);
            BtnValider.Click += new RoutedEventHandler(BtnValider_Click);
        }

        private void RbSolitaire_Click(object sender, RoutedEventArgs e)
        {
            if (RbSolitaire.IsChecked == true)
            {
                Tp.Visibility = Visibility.Hidden;
            }

            int tailleGrille = 9;
            int compteur = 1;
            Button[,] grilleSol = new Button[tailleGrille, tailleGrille];
            ColumnDefinition[] Cdef = new ColumnDefinition[tailleGrille];
            RowDefinition[] Rdef = new RowDefinition[tailleGrille];
            for (int i = 0; i < tailleGrille; i++)
            {
                Cdef[i] = new ColumnDefinition();
                secondGrid.ColumnDefinitions.Add(Cdef[i]);
                Rdef[i] = new RowDefinition();
                secondGrid.RowDefinitions.Add(Rdef[i]);
            }
            for (int i = 0; i < tailleGrille; i++)
            {
                for (int y = 0; y < tailleGrille; y++)
                {
                    if (i == 1 || i == 2 || i == 0 || i ==6 || i ==7 || i ==8)
                    {

                    }
                }
            }
        }

        private void RbMarelle_Click(object sender, RoutedEventArgs e)
        {
            if (RbMarelle.IsChecked == true)
            {
                Tp.Visibility = Visibility.Hidden;
            }
                int tailleGrille = 7;
            int compteur = 1;
            Button[,] grilleSol = new Button[tailleGrille, tailleGrille];
            ColumnDefinition[] Cdef = new ColumnDefinition[tailleGrille];
            RowDefinition[] Rdef = new RowDefinition[tailleGrille];
            for (int i = 0; i < tailleGrille; i++)
            {
                Cdef[i] = new ColumnDefinition();
                secondGrid.ColumnDefinitions.Add(Cdef[i]);
                Rdef[i] = new RowDefinition();
                secondGrid.RowDefinitions.Add(Rdef[i]);
            }
        }

        private void RbBandeL_Click(object sender, RoutedEventArgs e)
        {

            if (RbBandeL.IsChecked == true)
            {
                Tp.Visibility = Visibility.Visible;

                int NbreC = 12;
                int NbreL = 6;
                int compteur = 1;
                Button[,] grilleSol = new Button[NbreL, NbreC];
                ColumnDefinition[] Cdef = new ColumnDefinition[NbreC];
                RowDefinition[] Rdef = new RowDefinition[NbreL];
                for (int i = 0; i < NbreL; i++)
                {
                    Cdef[i] = new ColumnDefinition();
                    secondGrid.ColumnDefinitions.Add(Cdef[i]);
                    Rdef[i] = new RowDefinition();
                    secondGrid.RowDefinitions.Add(Rdef[i]);
                }
            }
            
        }

        private void TxtBLignes_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (uint.Parse(e.Text) <= 0 && uint.Parse(e.Text) >= 12)
            {
                return;
            }
        }

        private void TxtBColonnes_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (uint.Parse(e.Text) <= 0 && uint.Parse(e.Text) >= 12)
            {

            }
        }

        /*private void TxtBMessage_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                if (e.OldValue != null)
                {

                }
            }
        }*/

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
