using FacadePattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
            shapeMaker.DrawCircle();

            Console.ReadLine();
        }
    }
}
