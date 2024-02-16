using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Animal
    {
        protected string _nom;
        protected DateTime _dnaissance;
        protected string _puce;
        protected string _taille;
        protected bool _concours;

        public string Nom
        {
            get { return _nom; }
        }

        public DateTime Dnaissance
        {
            get { return _dnaissance; }
        }

        public string Puce
        {
            get { return _puce; }
            set { _puce = value; }
        }

        public string Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }
        public bool Concours
        {
            get { return _concours; }
            set { _concours = value; }
        }

        public Animal(string nom, DateTime date, string puce, string taille, bool concours)
        {
            _nom = nom;
            _dnaissance = date;
            _puce = puce;
            _taille = taille;
            _concours = concours;
        }

        public string Dormir()
        {
            string evenement = Nom + " est entrain de faire dodo... ZzZzZzZz";
            return evenement;
        }

        public virtual string Affiche()
        {
            string info = Nom + " est né(e) le "  + Dnaissance + ", il/elle possède une puce numérotée " + Puce + ", il/elle mesure " + Taille;
            return info;
        }

        public string Manger()
        {
            string evenement = Nom + " est entrain de manger... MIAM-MIAM";
            return evenement;
        }
    }   
}
