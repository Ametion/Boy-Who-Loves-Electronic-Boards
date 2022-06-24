using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Components.UI
{
    public class InventoryPanelTest : MonoBehaviour
    {
        private List<Text> _texts = new List<Text>();
        private ControllerForTest _controller;
        
        private void Start()
        {
            _controller = FindObjectOfType<ControllerForTest>();

            _texts = GetComponentsInChildren<Text>().ToList();
            
            for (int i = 0; i < _texts.Count; i++)
            {
                _texts[i].text = $"{_controller.Inventory.GetStuffName(i)}\n{_controller.Inventory.GetStuffModel(i)}";
            }
        }
    }
}