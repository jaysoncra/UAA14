// See https://aka.ms/new-console-template for more information
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using BDD_C;

static void Main(string[] args)
{
    string[] donnees = new string[5];
    DataSet immoBiens;
    MethodesDuProjet monModele = new MethodesDuProjet();
    Console.WriteLine("Liste des biens");
    Console.WriteLine("----------------------");
    if (monModele.ChercheBiens(out immoBiens))
    {
        string listBien = monModele.AfficheDataBiens(immoUsers);
        Console.WriteLine(listeBien);
    }
    else
    {
        Console.WriteLine("Pb lors de la lecture des données");
    }
    Console.WriteLine("Ajout d'un bien :");
    Console.WriteLine("------------------------");
    Console.WriteLine("Nom ? ");
    donnees[0] = Console.ReadLine();
    Console.WriteLine("Taille ? ");
    donnees[0] = Console.ReadLine();
    Console.WriteLine("Prix ? ");
    donnees[0] = Console.ReadLine();
    Console.WriteLine("Ville ? ");
    donnees[0] = Console.ReadLine();

    if (monModele.AjoutBien(donnees))
    {
        Console.WriteLine("Bien ajouté !");
    }
    else
    {
        Console.WriteLine("Problème lors de l'ajout !");
    }
    Console.ReadLine();
}