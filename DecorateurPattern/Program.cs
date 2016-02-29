using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateurPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pate p = new Pate();
            Console.WriteLine(p.AfficherIngredient());
            PateFeuilletee pf = new PateFeuilletee(p);
            Console.WriteLine(pf.AfficherIngredient());
            Console.WriteLine(pf.AjouterIngredient());

            Console.ReadLine();
        }
    }
}
