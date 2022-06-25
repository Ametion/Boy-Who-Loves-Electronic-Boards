using System;
using Components.Abstract;
using Components.Strategy.Stuffs;
using UnityEngine;

namespace Components.UI
{
    public class BuyStuffComponent : MonoBehaviour
    {
        [SerializeField] private string stuff;
        [SerializeField] private int price;
        [SerializeField] private string brand;
        [SerializeField] private string model;

        private ControllerForTest _controller;

        private void Awake()
        {
            _controller = FindObjectOfType<ControllerForTest>();
        }

        public void BuyStuff()
        {
            IPiece stuffToBuy;
            
            if (stuff == "Processor")
                stuffToBuy = new Processor(price, false, 2.4f, model, brand);
            
            else if (stuff == "GraphicCard") 
                stuffToBuy = new VideoCard(price, false, 2048, model, brand);
            
            else if (stuff == "RAM")
                stuffToBuy = new RAM(price, false, 3666, model, brand);
            
            else
                throw new Exception("You are trying to buy Stuff that doesn't exist");

            _controller.Inventory.AddToInventory(stuffToBuy);
        }
    }
}