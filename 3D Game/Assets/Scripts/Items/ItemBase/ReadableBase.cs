using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "Readable", menuName = "Item/Readables")]
    public class ReadableBase : ItemBase
    {
        [SerializeField] private string _text;
        public string Text => _text;
    }
}
