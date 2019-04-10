using UnityEngine;
using UnityEngine.UI;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.Utility
{
    public class TextReplacer : MonoBehaviour
    {
        public StringVariable Variable;

        public Text Text;

        public bool AlwaysUpdate;
        
        private void OnEnable() => SyncText();

        private void Update()
        {
            if (AlwaysUpdate)
                SyncText();
        }

        private void SyncText() => Text.text = Variable.Value;
    }
}