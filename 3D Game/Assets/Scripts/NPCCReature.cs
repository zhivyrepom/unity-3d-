using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCReature : Interactable
{
    protected override void Interact()
    {
        base.Interact();
        Debug.Log("Open chat with NPC");
    }
}
