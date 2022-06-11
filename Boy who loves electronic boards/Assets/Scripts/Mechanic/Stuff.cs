using Components.Abstract;

namespace Components.Mechanic
{
    public class Stuff  : IPiece
    {
        public string piece { get; }
        public int costOfPiece { get; set; }

        public Stuff(string Piece, int CostOfPiece)
        {
            
        }
    }
}