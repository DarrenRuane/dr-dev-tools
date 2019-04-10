using System;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.TypeAdapters.References
{
    [Serializable]
    public abstract class BaseReference<TPrimitive, TVariable> where TVariable : BaseVariable<TPrimitive, TVariable>
    {
        public bool UseConstant = true;
        public TPrimitive ConstantValue;
        public TVariable Variable;

        protected BaseReference() { }

        protected BaseReference(TPrimitive value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public TPrimitive Value => UseConstant ? ConstantValue : Variable.Value;

        public static implicit operator TPrimitive(BaseReference<TPrimitive, TVariable> reference) => reference.Value;
    }
}
