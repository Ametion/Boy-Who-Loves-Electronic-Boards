using Components.Abstract;

namespace Components.Strategy.Stuffs
{
    public class VideoCard : IPiece
    {
        public string Piece => "VideoCard";
        public int PriceOfPiece { get; set; }
        public bool IsBroken { get; set; }
        public string Model { get; }
        public string Brand { get; }
        public int Memory { get; }

        public VideoCard(int priceOfPiece, bool isBroken, int memory, string model, string brand)
        {
            PriceOfPiece = priceOfPiece;
            IsBroken = isBroken;
            Memory = memory;
            Model = model;
            Brand = brand;
        }
    }
}