using UnityEngine;

namespace DRDevTools.TypeAdapters.Variables
{
    public abstract class BaseVariable<TPrimitive, TVariable> : ScriptableObject where TVariable : BaseVariable<TPrimitive, TVariable>
    {
        [SerializeField]
        private TPrimitive value;

        public TPrimitive Value => value;

        public void SetValue(TPrimitive newValue) => value = newValue;

        public void SetValue(TVariable newValue) => value = newValue.Value;

        public static implicit operator TPrimitive(BaseVariable<TPrimitive, TVariable> variable) => variable.Value;

#if UNITY_EDITOR

        [Multiline]
        public string DeveloperDescription = string.Empty;

#endif
    }
}
