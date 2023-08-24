using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Factories
{
    public abstract class FigureFactory
    {
        public abstract Figure GetFigure();
    }
}
