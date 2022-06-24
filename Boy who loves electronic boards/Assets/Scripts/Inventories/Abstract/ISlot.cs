using Components.Abstract;

namespace Inventories.Abstract
{
    public interface ISlot
    {
        IPiece Stuff { get; set; }
        string StuffName { get; }
        int StuffPrice { get; }
        int MaxStuffInSlot { get; }

        void Clear();
    }
}