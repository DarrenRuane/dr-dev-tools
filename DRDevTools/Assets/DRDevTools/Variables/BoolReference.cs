using System;

namespace DRDevTools.Variables
{
    [Serializable]
    public class BoolReference
    {
        public bool UseConstant = true;
        public bool ConstantValue;
        public BoolVariable Variable;

        public BoolReference() { }

        public BoolReference(bool value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public bool Value => UseConstant ? ConstantValue : Variable.Value;

        public static implicit operator bool(BoolReference reference) => reference.Value;
    }
}