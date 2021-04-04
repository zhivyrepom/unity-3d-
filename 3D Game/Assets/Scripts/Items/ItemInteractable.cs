using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractable : Interactable 
{
    // Start is called before the first frame update
    ItemBody _itemBody;
    protected override void Start()
    {
        _itemBody = GetComponent<ItemBody>();
        base.Start();
    }

    protected override void Interact()
    {
        base.Interact();
        _itemBody.OnPickUp(_player);
    }
}
