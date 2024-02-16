using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Lapin : Animal
    {
        private string _oreille;

        public string Oreille
        {
            get{ return _oreille; }
            set { _oreille = value; }
        }

        public Lapin(string oreille, string nom, DateTime date, string puce, string taille, bool concours) : base(nom, date, puce, taille, concours)
        {
            _oreille = oreille;
        }

        public string Bond()
        {
            string evenement = "Boing-Boing";
            return evenement;
        }

        public override string Affiche()
        {
            return base.Affiche() + ", ses oreilles mesurent " + Oreille;
        }
    }
}
