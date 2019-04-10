using UnityEngine;

namespace DRDevTools.TypeAdapters.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector3")]
    public class Vector3Variable : BaseVariable<Vector3, Vector3Variable>
    {
        public override string ToString() => $"({Value.x}, {Value.y}, {Value.z})";
    }
}