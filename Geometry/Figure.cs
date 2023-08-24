namespace Geometry
{
    public abstract class Figure
    {
        //тут можно сделать area не double, а double? и далее проверять именно на null,
        //но в предметной области никогда не будет фигуры с площадью 0, поэтому оставил так и сравниваю с default
        protected double area;

        /// <summary>
        /// Calculating figure's area
        /// </summary>
        /// <returns>Figure's area</returns>
        public abstract double GetArea();
    }
}