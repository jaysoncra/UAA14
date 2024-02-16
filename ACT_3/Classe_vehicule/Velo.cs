using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classe_vehicule
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _estElectrique;

        public string Type
        { 
            get { return _type; }
            set { _type = value; }      
        }

        public bool EstElectrique
        {
            get { return _estElectrique; }
            set { _estElectrique = value; }
        }

        public Velo(string type, bool electrique, string modele, string marque, string couleur, decimal prix) : base (modele, marque, couleur, prix)
        {
            _type = type;
            _estElectrique = electrique;
            //_modele = modele;
            //_marque = marque;
            //_couleur = couleur;
            //_prix = prix;
        }

        public override string Affiche()
        {
            string info = Type + EstElectrique + Marque + Modele + Couleur + " de " + Prix + " €.";
            return info;
        }
    }
}
