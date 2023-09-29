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

namespace MatchingGame
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

        int index;
        Random nbAlea = new Random();
        string nextEmoji;
        private void SetUpGame()
        {
            List<string> emoji = new List<string>()
            {
                "🦓","🦓",
                "🦄","🦄",
                "🐺","🐺",
                "🦊","🦊",
                "🐴","🐴",
                "🦁","🦁",
                "🐯","🐯",
                "🐼","🐼",
            };

            foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>())
            {
                index = nbAlea.Next(emoji.Count); // index est un type int 
                // nbalea est un objet de type Random()
                nextEmoji = emoji[index]; // nextEamji est un type  string
                textBlock.Text = nextEmoji;
                emoji.RemoveAt(index); // on retire un animal de la liste pour ne pas l'attribuer à nouveau.
            }
                
        }
        TextBlock derniereTBClique; //on va l'utiliser  pour faire une référence à la TextBlock sur laquelle on vient de cliquer
        bool trouvePaire = false;


        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock texteBlockActif = sender as TextBlock;
            if (!trouvePaire)
            {
                texteBlockActif.Visibility = Visibility.Hidden;
                derniereTBClique = texteBlockActif;
                trouvePaire = true;
            }
            else if (texteBlockActif.Text == derniereTBClique.Text)
            {
                texteBlockActif.Visibility = Visibility.Hidden;
                trouvePaire = false;
            }
            else
            {
                derniereTBClique.Visibility   = Visibility.Visible;
                trouvePaire = false;
            }
        }
    }
}
