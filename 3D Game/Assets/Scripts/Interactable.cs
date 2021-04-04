﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    private bool _isFocused;
    private bool _hasInteracted; 
    protected  PlayerCreature _player;
    [SerializeField]private float _interactionDistance;
    public virtual float StopingDistance
    {
        get { return _interactionDistance * 0.7f; }
    }
          
    protected virtual void Start()
    {

    }

    // Start is called before the first frame update
    public void OnFocus(PlayerCreature player)
    {
        _isFocused = true;
        _player = player;
    }

    public void OnUnfocus()
    {
        _isFocused = false;
        _hasInteracted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isFocused && _player != null)
        {
            Vector3 centrePoint = new Vector3(transform.position.x, _player.transform.position.y, transform.position.z);
            if (Vector3.Distance(centrePoint, _player.transform.position) < _interactionDistance && !_hasInteracted)
            {
                Interact();
            }
        }
    }

    protected virtual void Interact()
    {
        _hasInteracted = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _interactionDistance);
    }
}
