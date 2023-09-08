// See https://aka.ms/new-console-template for more information

namespace Chien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste des chiens");
            ClasseChien chien1 = new ClasseChien("Happy", "Doberman", true, "Bosnie", "Male", "Noir et Feu", false, false, "Oreilles et queue coupées", true, true, false, true);
        }
    }
}