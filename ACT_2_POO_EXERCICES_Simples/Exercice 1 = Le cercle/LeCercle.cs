using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1___Le_cercle
{
    class LeCercle
    {
        private double _rayon;

        public LeCercle(double rayon)
        {
            _rayon = rayon;
        }

        public double Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }

       public double CalculeAire1()
        {
            double air1;
            return air1 = Math.PI * (_rayon * _rayon);
        }

        public double CalculeAire05()
        {
            double air05;
            return air05 = Math.PI * (_rayon / 2 * _rayon / 2);
        }


        public double CalculePerimetre1()
        {
            double perimetre1;
            return perimetre1 = 2 * Math.PI * _rayon;
        }

        public double CalculePerimetre05()
        {
            double perimetre05;
            return perimetre05 = Math.PI * _rayon;
        }

        public string AfficherLesCaracteristique1()
        {
            string chaine1 = "Le cercle de rayon " + _rayon + " a un périmetre de " + CalculePerimetre1() + " et a une aire de " + CalculeAire1();
            return chaine1;
        }

        public string AfficherLesCarateristques05()
        {
            string chaine05 = "Le cercle de rayon " + _rayon/2 + " a un périmetre de " + CalculePerimetre05() + " et a une aire de " + CalculeAire05();
            return chaine05;
        }
    }   
}
