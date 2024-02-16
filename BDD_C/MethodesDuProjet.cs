using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_C
{
    public struct MethodesDuProjet
    {
        public string DefinirCheminBD() //Détermine la chaîne de connexion
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query;
        }
    }
}
