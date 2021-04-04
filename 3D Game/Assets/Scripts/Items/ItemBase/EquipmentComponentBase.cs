using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "EquipmentComponent", menuName = "Item/EquipmentComponents")]
    public class EquipmentComponentBase : StatItemBase
    {
        [SerializeField] private EquipmentType[] _allowedEquipmentTypes;
        [SerializeField] private CompontentType _componentType;

        public EquipmentType[] AllowedEquipmentTypes => _allowedEquipmentTypes;
        public CompontentType ComponentType => _componentType;
    }
}
