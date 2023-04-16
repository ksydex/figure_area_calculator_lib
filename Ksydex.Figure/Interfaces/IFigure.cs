namespace Ksydex.Figure.Interfaces
{
    /// <summary>
    /// Represents a geometric figure with an area.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Gets the area of the figure.
        /// </summary>
        double Area { get; }
    }
}