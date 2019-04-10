using UnityEngine;

namespace DRDevTools.Variables
{
    [CreateAssetMenu(menuName = "Variables/Float")]
    public class FloatVariable : ScriptableObject
    {
#if UNITY_EDITOR

        [Multiline]
        public string DeveloperDescription = string.Empty;

#endif
        [SerializeField]
        private float value = 0.0f;

        public float Value => value;

        public void SetValue(float newValue) => value = newValue;

        public void SetValue(FloatVariable newFloat) => value = newFloat.Value;

        public void ApplyChange(float amount) => value += amount;

        public void ApplyChange(FloatVariable amount) => value += amount.Value;
    }
}