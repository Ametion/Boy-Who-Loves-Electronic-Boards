using System;
using Components.Abstract;

namespace Components.Mechanic
{
    public class BrokenStuff : IBroken
    {
        public IPiece Piece { get; set; }
        
        public int PriceToRepair { get; set; }
        
        public int PriceOfPiece
        {
            get
            {
                if (Piece != null) 
                    return Piece.PriceOfPiece;
                
                return 0;
            }
        }

        public int TotalPrice
        {
            get
            {
                if (Piece != null) 
                    return PriceOfPiece + PriceToRepair;
                
                return 0;
            }
        }

        public BrokenStuff(IPiece piece, int priceToRepair)
        {
            if (piece.IsBroken)
            {
                Piece = piece;
                PriceToRepair = priceToRepair;
            }
            else throw new Exception("You try to put not broken stuff to brokne stuff");
        }
    }
}