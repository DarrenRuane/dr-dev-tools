using System;
using UnityEngine;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.TypeAdapters.References
{
    [Serializable]
    public class Vector2Reference : BaseReference<Vector2, Vector2Variable>
    {
        public Vector2Reference() : base() { }

        public Vector2Reference(Vector2 value) : base(value) { }
    }
}