using Components.Abstract;

namespace Inventories.Abstract
{
    public interface IInventory
    {
        int Capacity { get; }
        bool IsFull { get; }

        void AddToInventory(IPiece stuff);
        void ClearSlot(int slotId);
    }
}