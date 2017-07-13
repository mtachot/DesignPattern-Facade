using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes
{
    public class ShapeMaker
    {
        private IShape rectangle;
        private IShape square;
        private IShape circle;

        public ShapeMaker()
        {
            this.rectangle = new Rectangle();
            this.square = new Square();
            this.circle = new Circle();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }
    }
}
