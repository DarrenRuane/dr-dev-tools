using System;
using UnityEngine;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.TypeAdapters.References
{
    [Serializable]
    public class Vector3Reference : BaseReference<Vector3, Vector3Variable>
    {
        public Vector3Reference() : base() { }

        public Vector3Reference(Vector3 value) : base(value) { }
    }
}