using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseChien
{
    class ClasseChien
    {
        private string _nom;
        private string _race;
        private bool _purRace;
        private string _provenance;
        private string _genre;
        private uint _age;
        private string _couleur;
        private bool _albinisme;
        private bool _melanisme;
        private string _particularitePhysique;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private bool _sterilise;
        private bool _dresse;


        public ClasseChien(string nom, string race, bool purRace, string provenance, string genre, uint age, string couleur, bool albinisme, bool melanisme, string particularitePhysique, bool enOrdreDeVaccin, bool puce, bool sterilise, bool dresse)
        {
            _nom = nom;
            _race = race;
            _purRace = purRace;
            _provenance = provenance;
            _genre = genre;
            _age = age;
            _couleur = couleur;
            _albinisme = albinisme;
            _melanisme = melanisme;
            _particularitePhysique = particularitePhysique;
            _enOrdreDeVaccin = enOrdreDeVaccin;
            _puce = puce;
            _sterilise = sterilise;
            _dresse = dresse;
        }

        public string AfficheCaracteristiques()
        {
            string chaine = "Nom : " + _nom + " Race - " + _race + " Pur race - " + _purRace + " Provenance - " + _provenance + " Genre - " + _genre + " Åge - " + _age + " Couleur - " + _couleur + " albinisme - " + _albinisme + " Mélanisme - " + _melanisme + " Particularité physique - " + _particularitePhysique + " En ordre de vaccin - " + _enOrdreDeVaccin + " Puce - " + _puce + " Stérilise - " + _sterilise + " Dressé - " + _dresse;
            return chaine;
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public bool PurRace
        {
            get { return _puce; }
            set { _puce = value; }
        }

        public string Provenance
        {
            get { return _provenance; }
            set { _provenance = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public uint Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public bool Albinisme
        {
            get { return _albinisme; }
            set { _albinisme = value;}
        }

        public bool Melanisme
        {
            get { return _melanisme; }
            set { _melanisme = value;}
        }

        public string ParticularitePhysique
        {
            get { return _particularitePhysique; }
            set { _particularitePhysique = value; }
        }

        public bool EnOrdreDeVaccin
        {
            get { return _enOrdreDeVaccin; }
            set { _enOrdreDeVaccin = value; }
        }

        public bool Puce
        {
            get { return _puce; }
            set { _puce = value; }
        }

        public bool Sterilise
        {
            get { return _sterilise; }
            set { _sterilise = value; }
        }

        public bool Dresse
        {
            get { return _dresse; }
            set { _dresse = value; }
        }


    }   
}
