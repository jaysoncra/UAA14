// See https://aka.ms/new-console-template for more information
using Heritage;

Console.WriteLine("Vous êtes ici");

Animal[] animaux = new Animal[5];
animaux[0] = new Chien("Happy", DateTime.Parse("20/11/2018"), "#81161625", "72 cm", false);
animaux[1] = new Chien("Medor", DateTime.Parse("04/9/2010"), "#13541518", "52cm", true);
animaux[2] = new Lapin("38cm","Noupi", DateTime.Parse("20/08/2013"), "#141521169","40cm", false);
animaux[3] = new Chat("Miaouss", DateTime.Parse("06/07/2016"), "#139115211919", "40cm", true);
animaux[4] = new Chien("Beethoven", DateTime.Parse("19/03/1992"), "#2552081522514", "90cm", true);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(animaux[i].Dormir());
    Console.WriteLine(animaux[i].Manger());
    Console.WriteLine(animaux[i].Affiche());

    if (animaux[i] is Chat chat)
    {
        Console.WriteLine(chat.Ronronner());
        Console.WriteLine(chat.Miauler());
    }
    else if (animaux[i] is Chien chien)
    {
        Console.WriteLine(chien.Aboyer());
    }
    else if (animaux[i] is Lapin lapin)
    {
        Console.WriteLine(lapin.Bond());
    }
}

