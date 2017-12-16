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
            int x = 1;
            Func1(x);
            Console.WriteLine("Func1.x = " + x);
            x = 1;
            Func2(x);
            Console.WriteLine("Func2.x = " + x);
            x = 1;
            Func3(x);
            Console.WriteLine("Func3.x = " + x);

            Poin p1 = new Poin(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Poin p2 = new Poin(4, 5, '#');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + "p1.y = " + p1.y + ", p2.x = " + p2.x + ", p2.y = " + p2.y);

            p1 = new Poin(1, 1, '*');
            Program.Update( p1 );
            Console.WriteLine("Call Update. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Console.ReadLine();
        }

        private static void Update(Poin p1)
        {
            throw new NotImplementedException();
        }

        public static void Func1(int value)
        {

        }
        public static void Func2(int value)
        {
            value++;
        }
        public static void Func3(int x)
        {
            x++;
        }
        public static void Move(Poin p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }
    }
}
