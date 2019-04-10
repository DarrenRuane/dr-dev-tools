using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DRDevTools.Utility.Serialisation;

namespace DRDevTools.Inventory
{
    [CreateAssetMenu(menuName = "Inventory/Inventory")]
    public class Inventory : ScriptableObject
    {
        private readonly Dictionary<string, InventoryItem> guidToItemMapping = new Dictionary<string, InventoryItem>();

        public InventoryItem[] Items = new InventoryItem[0];
        public Serialiser Serialiser;
        public InventoryState InventoryState;
        public UnityEvent OnInventoryChanged;

        private void OnEnable()
        {
            guidToItemMapping.Clear();

            foreach (var item in Items)
                guidToItemMapping.Add(item.Guid, item);

            InventoryState.OwnedItems.Clear();
            InventoryState.Set.Clear();

            foreach (var ownedGuid in InventoryState.OwnedGuids)
            {
                InventoryState.Set.Add(ownedGuid);
                InventoryState.OwnedItems.Add(guidToItemMapping[ownedGuid]);
            }
        }

        public void Save() => Serialiser.Serialise("inventory", InventoryState);

        public void Load()
        {
            Serialiser.Deserialise<InventoryState>("inventory", InventoryState);

            InventoryState.OwnedItems.Clear();
            InventoryState.Set.Clear();

            InventoryState.OwnedGuids.ForEach(guid =>
            {
                InventoryState.Set.Add(guid);
                InventoryState.OwnedItems.Add(guidToItemMapping[guid]);
            });

            OnInventoryChanged.Invoke();
        }

        public void GiveItem(InventoryItem item)
        {
            if (!InventoryState.Set.Add(item.Guid))
                return;

            InventoryState.OwnedGuids.Add(item.Guid);
            InventoryState.OwnedItems.Add(item);

            // Only raise the event if we actually added the item to the Inventory
            OnInventoryChanged.Invoke();
        }

        public void RemoveItem(InventoryItem item)
        {
            if (!InventoryState.Set.Remove(item.Guid))
                return;

            InventoryState.OwnedGuids.Remove(item.Guid);
            InventoryState.OwnedItems.Remove(item);

            // Only raise the event if we actually removed the item from the Inventory
            OnInventoryChanged.Invoke();
        }

#if UNITY_EDITOR

        private void OnValidate()
        {
            FindItems();
            var state = UnityEditor.AssetDatabase.LoadAssetAtPath<InventoryState>(UnityEditor.AssetDatabase.GetAssetPath(this));

            if (state == null)
            {
                state = ScriptableObject.CreateInstance<InventoryState>();
                state.name = "InventoryState";
                UnityEditor.AssetDatabase.AddObjectToAsset(state, this);
                UnityEditor.AssetDatabase.SaveAssets();
            }
            InventoryState = state;
        }

        [ContextMenu("Populate Items")]
        private void FindItems()
        {
            string[] guids = UnityEditor.AssetDatabase.FindAssets("t:" + typeof(InventoryItem).Name);
            Items = new InventoryItem[guids.Length];
            for (var i = 0; i < guids.Length; i++)
            {
                string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guids[i]);
                InventoryItem item = UnityEditor.AssetDatabase.LoadAssetAtPath<InventoryItem>(path);
                Items[i] = item;
                item.Guid = guids[i];
                UnityEditor.EditorUtility.SetDirty(this);
            }
        }

#endif
    }
}