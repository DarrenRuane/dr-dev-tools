using UnityEngine;

namespace DRDevTools.TypeAdapters.Variables
{
    [CreateAssetMenu(menuName = "Variables/Float")]
    public class FloatVariable : BaseVariable<float, FloatVariable>
    {
        public void ApplyChange(float amount) => SetValue(Value + amount);

        public void ApplyChange(FloatVariable amount) => ApplyChange(amount.Value);
    }
}