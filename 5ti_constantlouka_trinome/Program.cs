namespace _5ti_constantlouka_trinome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Résolution d'un trinome du second degré!");
            double a;
            double b;
            double c;
            string message;
            string repeatProg;
            do
            {
                Console.WriteLine("Encodez la valeur du coefficient du second degré");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Encodez la valeur du coefficient du premier degré");
                    b = double.Parse(Console.ReadLine());
                Console.WriteLine("Encodez la valeur du terme indépendant");
                    c = double.Parse(Console.ReadLine());

                ResoudTrinome(a, b, c ,out message);
                Console.WriteLine(message);

                Console.WriteLine("Voulez-vous recommencer ?  'O' = oui, 'N' = non");
                repeatProg = Console.ReadLine();
            } while (repeatProg == "O");
        }

        static void ResoudTrinome(double a, double b, double c, out string message)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if ( delta < 0) 
            {
                message = "Il n'y a pas de solution réelle";
            
            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                    message = "Il y a une solution " + x1;
            }    
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
            }
        }
                  
                    
                    



            }

        }
    
