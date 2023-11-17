// See https://aka.ms/new-console-template for more information
using Exercice_1___Le_cercle;
bool restart = false;
double rayon;
do
{
    Console.WriteLine("Bienvenu dans ce programme sur le cercle !\n Tapez un rayon pour votre cercle.");
    rayon = double.Parse(Console.ReadLine());
    LeCercle monCercle = new LeCercle(rayon);
    
    Console.WriteLine(monCercle.AfficherLesCaracteristique1);
    Console.WriteLine("Avec un cercle de rayon diminuer de moitié :");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine(monCercle.AfficherLesCarateristques05);
    Console.WriteLine("Un autre cercle ? (Tapez sur espace)");
    string reponse = Console.ReadLine();
    if (reponse == " ")
    {
        restart = false;
        Console.Clear();
    }
    else
    {
        restart = true;
    }
} while (restart == false);