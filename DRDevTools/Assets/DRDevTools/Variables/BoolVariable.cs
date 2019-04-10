using UnityEngine;

namespace DRDevTools.Variables
{
    [CreateAssetMenu(menuName = "Variables/Boolean")]
    public class BoolVariable : ScriptableObject
    {
#if UNITY_EDITOR

        [Multiline]
        public string DeveloperDescription = string.Empty;

#endif
        public bool Value;

        public void SetValue(bool value) => Value = value;

        public void SetValue(BoolVariable value) => Value = value.Value;
    }
}