using System;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.TypeAdapters.References
{
    [Serializable]
    public class FloatReference : BaseReference<float, FloatVariable>
    {
        public FloatReference() : base() { }

        public FloatReference(float value) : base(value) { }
    }
}