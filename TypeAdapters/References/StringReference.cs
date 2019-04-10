using System;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.TypeAdapters.References
{
    [Serializable]
    public class StringReference : BaseReference<string, StringVariable>
    {
        public StringReference() : base() { }

        public StringReference(string value) : base(value) { }
    }
}
