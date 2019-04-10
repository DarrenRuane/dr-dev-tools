using System;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.TypeAdapters.References
{
    [Serializable]
    public class BoolReference : BaseReference<bool, BoolVariable>
    {
        public BoolReference() : base() { }

        public BoolReference(bool value) : base(value) { }
    }
}