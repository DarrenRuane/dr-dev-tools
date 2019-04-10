using UnityEngine;

namespace DRDevTools.Variables
{
    [CreateAssetMenu(menuName = "Variables/String")]
    public class StringVariable : ScriptableObject
    {
#if UNITY_EDITOR

        [Multiline]
        public string DeveloperDescription = string.Empty;

#endif

        [SerializeField]
        private string value = string.Empty;

        public string Value
        {
            get => value;
            set => this.value = value;
        }
    }
}