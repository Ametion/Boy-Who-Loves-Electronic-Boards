using System.Collections.Generic;
using Components.Mechanic;
using Components.Strategy.Stuffs;
using UnityEngine;

namespace Components
{
    public class ControllerForTest : MonoBehaviour
    {
        public Inventory Inventory;
        public List<Mission> Missions = new List<Mission>();

        private void Awake()
        {
            Inventory = new Inventory(20);
            
            VideoCard videoCard = new VideoCard(1200, true, 6248, "RTX 3050TI", "NVideo" );
            BrokenStuff brokenStuff = new BrokenStuff(videoCard, 250);

            Mission newMission = new Mission("Repair Video Card", 400, brokenStuff);

            Missions.Add(newMission);

            Inventory.AddToInventory(videoCard);
            Inventory.AddToInventory(videoCard);
            Inventory.AddToInventory(videoCard);
        }
    }
}