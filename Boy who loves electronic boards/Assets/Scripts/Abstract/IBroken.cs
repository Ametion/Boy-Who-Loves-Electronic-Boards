namespace Components.Abstract
{
    public interface IBroken
    {
        IPiece Piece { get; set; }
        int PriceToRepair { get; set; }
        int PriceOfPiece { get; }
        int TotalPrice { get; }
    }
}