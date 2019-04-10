using UnityEngine;

namespace DRDevTools.Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector2")]
    public class Vector2Variable : ScriptableObject
    {
        public Vector2 Value;

        public static implicit operator Vector2(Vector2Variable vector) => vector.Value;
    }
}
