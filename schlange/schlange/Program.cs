using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schlange
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            //int x2 = 4, y2 = 5;
            //char sym2 = '#';

            //Draw(x2, y2, sym2);

            p2.Draw();

            
            Console.ReadKey();
        }

        
    }
}
