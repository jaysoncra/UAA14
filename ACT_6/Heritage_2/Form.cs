using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_2
{
    internal class Form
    {
        protected string _couleur;

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public Form(string couleur)
        {
            _couleur= couleur;
        }

        public float CalculeSurface(uint Longeur, uint Largeur)
        {
            uint s = Longeur * Largeur;
            return s;
        }
        public float CalculePerimetre(uint Longeur, uint Largeur)
        {
            uint p = (Longeur + Largeur) * 2;
            return p;
        }
    }
}
