using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_VotreNom
{
    internal class I2P623_CARAjayson
    {

        private int _couleur;
        private string _identifiant;
        
        public Feu(int couleur, string identifiant)
        {
            _couleur = couleur;
            _identifiant = identifiant;
        }

        public int Couleur
        {
            set { _couleur = value; }
            get { return _couleur; }
        }

        public string Identifiant
        {
            set { _identifiant = value; }
            get { return _identifiant; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Change()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Le feu de signalisation " + Identifiant + " est " + Color);
                Couleur++;
            }
        }

        public void Clignote(int frequence)
        {                      
                Console.WriteLine(Identifiant + " est éteint");
                Console.WriteLine(Identifiant + " est allumé");
                Console.WriteLine(Identifiant + " est éteint");
                Console.WriteLine(Identifiant + " est allumé");
                Console.WriteLine(Identifiant + " est éteint");
        }
        
        public void AfficheEtat()
        {
            Console.WriteLine("Le feu de signalisation " +  Identifiant + " est " + Couleur);
        }

        public void Color()
        {
            if (Couleur == 0)
            {
                Couleur = int.Parse("vert");
            }
            else if (Couleur == 1)
            {
                Couleur = int.Parse("orange");
            }
            else if (Couleur == 2)
            {
                Couleur = int.Parse("Rouge");
            }
            else if (Couleur == 3)
            {
                Couleur = 0;
            }

        }

    }
}
