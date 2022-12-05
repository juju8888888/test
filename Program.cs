using System;

namespace Mot_meles_Odoni_LeGall
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur j1 = new Joueur("borice");
            Console.WriteLine(j1.ToString());
            j1.Add_Score(1);
            j1.Add_Mot("lala");
            Console.WriteLine(j1.ToString());



        }

    }
}
