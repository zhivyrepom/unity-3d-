using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "Potion", menuName = "Item/Potions")]
    public class PotionBase : ItemBase
    {
        [SerializeField] private int _potionLvl;

        public int PotionLvl => _potionLvl;
    }
}

