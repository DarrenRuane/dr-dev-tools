using UnityEngine;

namespace DRDevTools.Variables
{
    [CreateAssetMenu(menuName = "Variables/Integer")]
    public class IntVariable : ScriptableObject
    {
#if UNITY_EDITOR

        [Multiline]
        public string DeveloperDescription = string.Empty;

#endif

        public int Value { get; set; }
    }
}
