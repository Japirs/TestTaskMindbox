namespace FigureArea.Interfaces
{
    public interface ITriangle: IFigure
    {
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }

        bool IsRightTriangle();
    }
}