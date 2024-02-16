using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Chat : Animal
    {
        public Chat(string nom, DateTime date, string puce, string taille, bool concours) : base(nom, date, puce, taille, concours)
        {
            //il n'y a rien car le "chat" n'a pas d'objet spécifique
        }

        public string Miauler()
        {
            string evenement = "Miaou";
            return evenement;
        }

        public string Ronronner()
        {
            string evenement = "Ronron";
            return evenement;
        }
    }
}
