using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Factories
{
    public class TriangleFactory : FigureFactory
    {
        private readonly List<double> sides;

        public TriangleFactory(double side1, double side2, double side3)
        {
            sides = new List<double>() { side1, side2, side3 };
        }

        public override Figure GetFigure()
        {
            Triangle figure = new Triangle(sides[0], sides[1], sides[2]);
            return figure;
        }
    }
}
