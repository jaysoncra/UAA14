using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseChien
{
    internal class ClasseChien
    {
        private string _nom;
        private string _race;
        private bool _purRace;
        private string _provenance;
        private bool _genre;
        private uint _age;
        private string _couleur;
        private bool _albinos;
        private bool _melanisme;
        private string _particularitePhysique;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private bool _sterilise;
        private bool _dresse;


        public ClasseChien(string nom, string race, bool purRace, string provenance, bool genre, uint age, string couleur, bool albinos, bool melanisme, string particularitePhysique, bool enOrdreDeVaccin, bool puce, bool sterilise, bool dresse)
        {
            _nom = nom;
            _race = race;
            _purRace = purRace;
            _provenance = provenance;
            _genre = genre;
            _age = age;
            _couleur = couleur;
            _albinos = albinos;
            _melanisme = melanisme;
            _particularitePhysique = particularitePhysique;
            _enOrdreDeVaccin = enOrdreDeVaccin;
            _puce = puce;
            _sterilise = sterilise;
            _dresse = dresse;
        }

        public string AfficheCaracteristiques()
        {
            string chaine = "Nom : " + _nom + " Race - " + _race + " Pur race - " + _purRace + " Provenance - " + _provenance + " Genre - " + _genre + " Åge - " + _age + " Couleur - " + _couleur + " Albinos - " + _albinos + " Mélanisme - " + _melanisme + " Particularité physique - " + _particularitePhysique + " En ordre de vaccin - " + _enOrdreDeVaccin + " Puce - " + _puce + " Stérilise - " + _sterilise + " Dressé - " + _dresse;
            return chaine;
        }


    }
}
