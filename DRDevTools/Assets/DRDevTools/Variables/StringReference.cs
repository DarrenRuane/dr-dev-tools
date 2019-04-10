using System;

namespace DRDevTools.Variables
{
    [Serializable]
    public class StringReference
    {
        public bool UseConstant = true;
        public string ConstantValue;
        public StringVariable Variable;

        public StringReference() { }

        public StringReference(string value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public string Value => UseConstant ? ConstantValue : Variable.Value;

        public static implicit operator string(StringReference reference) => reference.Value;
    }
}
