namespace Components.Abstract
{
    public interface IBroken
    {
        int priceToRepair { get; set; }
        IPiece piece { get; set; }
        int pieceOfPrice { get; }
        int totalPrice { get; }
    }
}