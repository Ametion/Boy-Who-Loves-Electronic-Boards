using Components.Abstract;
using Inventories.Abstract;

public class Slot : ISlot
{
    public IPiece Stuff { get; set; }

    public string StuffName
    {
        get
        {
            if (Stuff != null)
                return Stuff.Piece;

            return "There is no Stuff in slot";
        }
    }

    public int StuffPrice
    {
        get
        {
            if (Stuff != null)
                return Stuff.PriceOfPiece;

            return 0;
        }
    }
    
    public int MaxStuffInSlot { get; }

    public int StuffAmount;
    public int SlotId;

    public Slot(int maxItemInSlot) => MaxStuffInSlot = maxItemInSlot;

    public Slot(IPiece stuff, int maxItemInSlot)
    {
        Stuff = stuff;
        MaxStuffInSlot = maxItemInSlot;
    }

    public void Clear()
    {
        Stuff = null;
        StuffAmount = 0;
    }
}