using Components.Abstract;

namespace Components.Mechanic
{
    public class BrokenStuff : IBroken
    {
        public int priceToRepair { get; set; }
        public IPiece piece { get; set; }

        public int pieceOfPrice
        {
            get
            {
                if (piece != null) return piece.costOfPiece;
                else return 0;
            }
        }

        public int totalPrice
        {
            get
            {
                if (piece != null) return pieceOfPrice + priceToRepair;
                else return 0;
            }
        }

        public BrokenStuff(IPiece Piece, int PriceToRepair)
        {
            piece = Piece;
            priceToRepair = PriceToRepair;
        }
    }
}