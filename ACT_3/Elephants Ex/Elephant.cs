using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephants_Ex
{
    internal class Elephant
    {
        private string _nom;
        private uint _tailleOreilles;


        public Elephant(string nom, uint tailleOreilles)
        {
            _nom = nom;
            _tailleOreilles = tailleOreilles;
           
        }

        public void QuiJeSuis()
        {
            Console.WriteLine("Je m'appelle " +  _nom + ".\n" + " Mes oreilles mesurent " + _tailleOreilles + ".");
        }

        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);
        }

        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }

    }
}
