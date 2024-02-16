using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_2
{
    internal class Rectangle : Form
    {
        private uint _longeur;
        private uint _largeur;

        public Rectangle(uint longeur, uint largeur, string couleur) : base(couleur)
        {
            _longeur = longeur;
            _largeur = largeur;
        }
    }
}
