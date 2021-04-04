using UnityEngine;
using Player;

namespace Items
{
    public abstract class ItemBase : ScriptableObject
    {
        [SerializeField] private ItemId _itemId;
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        [SerializeField] private int _cost;
        [SerializeField] private int _stackCount;
        [SerializeField] private Sprite _inventoryIcon;
        public ItemId ItemId => _itemId;
        public string Name => _name;
        public string Description => _description;
        public int StackCount => _stackCount;
        public int Cost => _cost;
        public Sprite InventoryIcon => _inventoryIcon;
    }

    public abstract class StatItemBase : ItemBase
    {
        [SerializeField] private int _requiredLvl;
        [SerializeField] private ItemStat[] _primaryStats;

        public int RequiredLvl => _requiredLvl;
        public ItemStat[] PrimaryStas => _primaryStats;
    }
}




