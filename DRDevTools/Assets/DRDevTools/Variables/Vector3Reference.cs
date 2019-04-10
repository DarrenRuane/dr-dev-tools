using System;
using UnityEngine;

namespace DRDevTools.Variables
{
    [Serializable]
    public class Vector3Reference : MonoBehaviour
    {
        public Vector3Variable Variable;
        public Vector3 ConstantValue;

        public bool UseConstant = true;

        public Vector3Reference() { }

        public Vector3Reference(Vector3 value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public Vector3 Value => UseConstant ? ConstantValue : Variable.Value;

        public static implicit operator Vector3(Vector3Reference reference) => reference.Value;
    }
}