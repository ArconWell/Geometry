using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Factories
{
    public class CircleFactory : FigureFactory
    {
        private readonly double radius;

        public CircleFactory(double radius)
        {
            this.radius = radius;
        }

        public override Figure GetFigure()
        {
            Circle figure = new Circle(radius);
            return figure;
        }
    }
}
