using Components.Abstract;

namespace Components.Strategy.Stuffs
{
    public class RAM : IPiece
    {
        public string Piece => "RAM";
        public int PriceOfPiece { get; set; }
        public bool IsBroken { get; set; }
        public string Brand { get; }
        public string Model { get; }
        
        public float Frequency { get; }

        public RAM(int priceOfPiece, bool isBroken, float frequency, string model, string brand)
        {
            PriceOfPiece = priceOfPiece;
            IsBroken = isBroken;
            Frequency = frequency;
            Model = model;
            Brand = brand;
        }
    }
}