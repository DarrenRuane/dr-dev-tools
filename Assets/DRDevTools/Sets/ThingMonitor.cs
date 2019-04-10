using UnityEngine;
using UnityEngine.UI;

namespace DRDevTools.Sets
{
    public class ThingMonitor : MonoBehaviour
    {
        private int previousCount = -1;

        public ThingRuntimeSet Set;
        public Text Text;

        public void UpdateText() => Text.text = "There are " + Set.Items.Count + " things.";

        private void OnEnable() => UpdateText();

        private void Update()
        {
            if (previousCount == Set.Items.Count)
                return;

            UpdateText();
            previousCount = Set.Items.Count;
        }
    }
}