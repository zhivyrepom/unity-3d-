using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : Interactable
{
    protected override void Interact()
    {
        base.Interact();
        Debug.Log("Fight with Enemy (Red Knight)");
    }
}
