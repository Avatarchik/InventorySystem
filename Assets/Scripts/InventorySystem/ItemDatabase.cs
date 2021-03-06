﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.InventorySystem
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Database")]
    public class ItemDatabase : ScriptableObject
    {
        [SerializeField] private List<ItemData> itemDataList;
        [SerializeField] private List<ItemVisual> itemVisualList;

        public List<ItemData> ItemDataList
        {
            get { return (List<ItemData>) Utilities.DeepClone(itemDataList); }
        }

        public List<ItemVisual> ItemVisualList
        {
            get { return itemVisualList; }
        }
    }
}
