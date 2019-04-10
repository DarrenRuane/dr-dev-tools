using System;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.TypeAdapters.References
{
    [Serializable]
    public class IntReference : BaseReference<int, IntVariable>
    {
        public IntReference() : base() { }

        public IntReference(int value) : base(value) { }
    }
}