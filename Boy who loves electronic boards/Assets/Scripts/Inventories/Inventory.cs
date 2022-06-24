using System;
using System.Collections.Generic;
using Components.Abstract;
using Inventories.Abstract;

public class Inventory : IInventory
{
    private List<Slot> _inventory;

    public int Capacity { get; }
    public bool IsFull { get; }
        
    public Inventory(int capacity)
    {
        Capacity = capacity;

        _inventory = new List<Slot>();

        for (int i = 0; i < capacity; i++)
        {
            var newSlot = new Slot(2);
            _inventory.Add(newSlot);
            _inventory[i].SlotId = i;
        }
    }

    public void AddToInventory(IPiece stuff)
    {
        var slotWithSameStuff = _inventory.Find(slot => slot.Stuff == stuff);

        if (slotWithSameStuff != null && slotWithSameStuff.StuffAmount + 1 <= slotWithSameStuff.MaxStuffInSlot)
        {
            slotWithSameStuff.StuffAmount++;
            return;
        }
        
        var emptySlot = _inventory.Find(slot => slot.Stuff == null);

        if (emptySlot != null)
        {
            emptySlot.Stuff = stuff;
            emptySlot.StuffAmount = 1;
            return;
        }

        throw new Exception("No available slots to this stuff, stackoverflow inventory");
    }

    public void ClearSlot(int slotId)
    {
        var slotForClear = _inventory.Find(slot => slot.SlotId == slotId);
        
        slotForClear.Clear();
    }

    public string GetStuffName(int slotId) => _inventory.Find(slot => slot.SlotId == slotId).StuffName;

    public string GetStuffModel(int slotId)
    {
        var slot = _inventory.Find(slot => slot.SlotId == slotId);
        
        if(slot.Stuff != null)
            return slot.Stuff.Model;
        
        return "No stuff in this Slot";
    }
}