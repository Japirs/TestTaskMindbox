namespace FigureArea.Interfaces
{
    public interface IFigure
    {
        /// <summary>
        /// Returns the area of a figure.
        /// ArgumentException if the input arguments are invalid.
        /// </summary>
        /// <returns>double Square</returns>
        double GetSquare();
    }
}