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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            List<Poin> pList = new List<Poin>();
            pList.Add(p1);
            pList.Add(p2);

            numList.Remove(0);

            Console.ReadLine();
        }       
    }
}
