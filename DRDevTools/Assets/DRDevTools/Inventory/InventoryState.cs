using System.Collections.Generic;
using UnityEngine;

namespace DRDevTools.Inventory
{
    public class InventoryState : ScriptableObject
	{
		public List<string> OwnedGuids = new List<string> ();
		public HashSet<string> Set = new HashSet<string>();
		public List<InventoryItem> OwnedItems = new List<InventoryItem>();
	}
}