﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Items;

public class ItemSlot : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] protected Image _slotImage;
    public bool IsEquiped { get; private set; }
    public Item SlotItem { get; private set; }
    public Image SlotImage => _slotImage;

    public bool SlotInteractable { get; protected set; }
    public PlayerCreature PlayerCreature { get; set; }

    public Action<ItemSlot> LeftPointerClicked = delegate { };
    public Action<ItemSlot> RightPointerClicked = delegate { };

    
    public void AddItemToSlot(Item item)
    {
        if(IsEquiped)
            RemoveItem();

        SlotItem = item;
        IsEquiped = true;
        _slotImage.sprite = SlotItem.InventoryIcon;
        _slotImage.color = Color.white;
    }

    public virtual void RemoveItem()
    {
        _slotImage.sprite = null;
        _slotImage.color = Color.clear;
        SlotItem = null;
        IsEquiped = false;
    }
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            OnLeftPoiterDown();
        }

        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (PlayerCreature.PlayerInventoryController.MovingItem != null)
                return;
            OnRightPointerDown();
        }
    }

    protected void SetSlotInteractability(bool isInteractable)
    {
        _slotImage.color = !isInteractable ? Color.red : IsEquiped ? Color.white : Color.clear;
    }

    protected virtual void OnLeftPoiterDown()
    {
        LeftPointerClicked(this);
        Debug.Log("LeftClick");
    }

    protected virtual void OnRightPointerDown()
    {
        if (!IsEquiped)
            return;

        RightPointerClicked(this);
        Debug.Log("RightClick");
    }
}
