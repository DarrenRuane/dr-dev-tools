using System.Collections.Generic;
using UnityEngine;

namespace DRDevTools.Inventory
{
    public class Equipper : MonoBehaviour
    {
        private readonly List<GameObject> items = new List<GameObject>();

        public Inventory Inventory;

        public void Refresh()
        {
            items.ForEach(item => Destroy(item.gameObject));
            items.Clear();

            Inventory.InventoryState.OwnedItems.ForEach(inventoryItem =>
            {
                var item = Instantiate(inventoryItem.Prefab);
                item.transform.parent = transform;
                item.transform.localPosition = Vector3.zero;
                item.transform.localRotation = Quaternion.identity;
                items.Add(item);
            });
        }

        private void OnEnable() => Refresh();
    }
}