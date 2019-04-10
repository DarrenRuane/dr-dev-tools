using UnityEngine;

namespace DRDevTools.Sets
{
    public class ThingDisabler : MonoBehaviour
    {
        public ThingRuntimeSet Set;

        public void DisableAll()
        {
            // Loop backwards since the list may change when disabling
            for (var i = Set.Items.Count-1; i >= 0; i--)
                Set.Items[i].gameObject.SetActive(false);
        }

        public void DisableRandom()
        {
            var index = Random.Range(0, Set.Items.Count);
            Set.Items[index].gameObject.SetActive(false);
        }
    }
}