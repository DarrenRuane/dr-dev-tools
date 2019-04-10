using System;

namespace DRDevTools.Variables
{
    [Serializable]
    public class IntReference
    {
        public IntVariable Variable;
        public int ConstantValue;
        public bool UseConstant = true;

        public IntReference() { }

        public IntReference(int value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public int Value => UseConstant ? ConstantValue : Variable.Value;

        public static implicit operator int(IntReference reference) => reference.Value;
    }
}