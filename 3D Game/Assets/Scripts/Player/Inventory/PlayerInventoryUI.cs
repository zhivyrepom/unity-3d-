using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;
using UnityEngine.UI;

public class PlayerInventoryUI : MonoBehaviour
{
    [SerializeField] private GameObject _inventoryGrid;
    [SerializeField] private Image _movingImage;
    public InventorySlot[] BaseInentroySlots { get; private set; }
    public Image MovingImage => _movingImage;
    

    public void InitComponents()
    {
        BaseInentroySlots = _inventoryGrid.GetComponentsInChildren<InventorySlot>();
    }

    public InventorySlot GetFreeSlot()
    {
        for(int i =0; i< BaseInentroySlots.Length; i++)
        {
            if(!BaseInentroySlots[i].IsEquiped)
            {
               Debug.Log("Pick up this");
               return  BaseInentroySlots[i];
            }
        }
        return null;
    }
}
