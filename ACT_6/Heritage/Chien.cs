using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Chien :Animal
    {
        public Chien(string nom, DateTime date, string puce, string taille, bool concours) : base(nom, date, puce, taille, concours)
        {
            //il n'y a rien car le "chien" n'a pas d'objet spécifique
        }

        public string Aboyer()
        {
            string evenement = "Woof-Woof";
            return evenement;
        }
    }
}
