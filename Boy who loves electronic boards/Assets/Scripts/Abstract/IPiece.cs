namespace Components.Abstract
{
    public interface IPiece : IModel
    {
        string Piece { get; }
        int PriceOfPiece { get; set; }
        bool IsBroken { get; set; }
    }
}