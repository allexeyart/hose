using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Poin p1 = new Poin(1, 3, '*');
            p1.Draw();

            Poin p2 = new Poin(4, 5, '#');            
            p2.Draw();

            Console.ReadLine();
        }        
    }
}
