// See https://aka.ms/new-console-template for more information
using Elephants_Ex;

Console.WriteLine("Hello, World!");
Console.WriteLine("Bienvenu sur cet échange d'éléphants\nTapez : \n1 - Pour afficher les informations de Zozou;\n2 - Pour afficher les informations de Titi;\n3 - Pour les échanger;\n4 - Pour voir les échanges de messages entre Zazou et Titi;\n5 - Pour réviser la notion de tableaux et l'appliquer à des objets.\n");

Elephant Zazou = Elephant("Zouzou", "82");
Elephant Titi = Elephant("Titi", "100");

string choixUser = Console.ReadLine();
switch (choixUser)
{
	case "1":
		Console.WriteLine();
}