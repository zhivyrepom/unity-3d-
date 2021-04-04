using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;

public class ItemBody : MonoBehaviour
{
    [SerializeField] private ItemBase _itemBase;
    private MeshRenderer _meshRenderer;
    private MeshFilter _meshFilter;
    private Collider _itemCollider;
    private Item _item;

    private void Start()
    {
        _meshRenderer = GetComponentInChildren<MeshRenderer>();
        _meshFilter = GetComponentInChildren<MeshFilter>();
        _itemCollider = GetComponentInChildren<Collider>();
        _item = new Equipment(_itemBase as EquipmentBase);
    }

    public void Init(Mesh mesh, Material material, Item item)
    {
        _meshRenderer.material = material;
        _meshFilter.mesh = mesh;
        _itemCollider = gameObject.AddComponent<Collider>();
        _item = item;
    }

    public void OnPickUp(PlayerCreature player)
    {
        if(player.PlayerInventoryController.AddItemToInventory(_item))
        {
            _item.SetOwner(player);
            Destroy(_itemCollider);
        }
    }
}
