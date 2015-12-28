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
            //Point p1 = new Point(1, 3, '*'); 
            //p1.Draw();


            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            //Point p1 = new Point(1, 2, '!');
            //Point p2 = new Point(3, 4, '@');
            //Point p3 = new Point(5, 6, '#');
            //Point p4 = new Point(7, 8, '$');


            //List<Point> pList = new List<Point>();
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);
            //pList.Add(p4);

            //pList[0].Draw();
            //pList[1].Draw();
            //pList[2].Draw();
            //pList[3].Draw();

            Point[] myP = new Point[4];
            myP[0] = new Point(1, 2, '!');
            myP[1] = new Point(3, 4, '@');
            myP[2] = new Point(5, 6, '#');
            myP[3] = new Point(7, 8, '$');

            foreach (Point item in myP)
            {
                item.Draw();
            }


            Console.ReadKey();
        }

        
    }
}
