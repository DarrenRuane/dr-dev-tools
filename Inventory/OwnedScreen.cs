using UnityEngine;
using UnityEngine.UI;

namespace DRDevTools.Inventory
{
    public class OwnedScreen : MonoBehaviour
    {
        private GameObject[] buttons = new GameObject[0];

        public GameObject ButtonTemplate;
        public Inventory Inventory;

        public void Refresh()
        {
            ButtonTemplate.SetActive(false);

            foreach (var button in buttons)
                Destroy(button.gameObject);

            buttons = new GameObject[Inventory.InventoryState.OwnedItems.Count];

            for (var index = 0; index < Inventory.InventoryState.OwnedItems.Count; index++)
            {
                var i = index; // Capture the value of index locally due to the AddListener closure that occurs below
                var button = Instantiate(ButtonTemplate);
                button.SetActive(true);
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                button.GetComponentInChildren<Text>().text = Inventory.InventoryState.OwnedItems[i].name;
                buttons[i] = button;
                button.GetComponent<Button>().onClick.AddListener(() => Inventory.RemoveItem(Inventory.InventoryState.OwnedItems[i]));
            }
        }

        private void OnEnable() => Refresh();
    }
}