// See https://aka.ms/new-console-template for more information

namespace ClasseChien
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreDeChien;
            
            
            
            
            Console.WriteLine("Bienvenue, combien de chien(s) voulez aimeriez vous enregister ?");
            nombreDeChien = int.Parse(Console.ReadLine());


            ClasseChien[] meschiens = new ClasseChien[nombreDeChien];

            for (int i = 0; i < nombreDeChien-1; i++)
            {

            }

           
        }
    }
}