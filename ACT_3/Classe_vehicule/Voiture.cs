using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classe_vehicule
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public string Motoriqtaion
        { 
            get { return _motorisation; } 
            set { _motorisation = value; }
        }

        public bool Gps
        { 
            get { return _gps; } 
            set {  _gps = value; }
        }

        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base (modele, marque, couleur, prix)
        {
            motorisation = _motorisation;
            gps = _gps;
        }

        public override string Affiche()
        {
            string info = Marque + Modele + Couleur + " de " + Prix + " euros.";
            return info;
        }
    }
}
