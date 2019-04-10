using UnityEngine;

namespace DRDevTools.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector3")]
    public class Vector3Variable : ScriptableObject
    {
#if UNITY_EDITOR

        [Multiline]
        public string DeveloperDescription = string.Empty;

#endif

        [SerializeField]
        private Vector3 value = Vector3.zero;

        public Vector3 Value
        {
            get => value;
            set => this.value = value;
        }
    }
}