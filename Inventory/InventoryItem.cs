using UnityEngine;

namespace DRDevTools.Inventory
{
    [CreateAssetMenu(menuName = "Inventory/Inventory Item")]
	public class InventoryItem : ScriptableObject
	{
		public string Guid = string.Empty;
		public GameObject Prefab;
	}
}