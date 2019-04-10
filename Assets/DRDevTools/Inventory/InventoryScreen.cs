using UnityEngine;
using UnityEngine.UI;

namespace DRDevTools.Inventory
{
    public class InventoryScreen : MonoBehaviour
    {
        private GameObject[] buttons = new GameObject[0];

        public GameObject ButtonTemplate;
        public Inventory Inventory;

        public void Refresh()
        {
            ButtonTemplate.SetActive(false);

            foreach (var button in buttons)
                Destroy(button.gameObject);

            buttons = new GameObject[Inventory.Items.Length];

            for (var index = 0; index < Inventory.Items.Length; index++)
            {
                var i = index; // Capture the value of index locally due to the AddListener closure that occurs below
                var button = Instantiate(ButtonTemplate);
                button.SetActive(true);
                button.transform.SetParent(ButtonTemplate.transform.parent, false);
                button.GetComponentInChildren<Text>().text = Inventory.Items[i].name;
                button.GetComponent<Button>().onClick.AddListener(() => Inventory.GiveItem(Inventory.Items[i]));
                buttons[i] = button;
            }
        }

        private void OnEnable() => Refresh();
    }
}