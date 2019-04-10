using UnityEngine;

namespace DRDevTools.Utility.Serialisation
{
    public abstract class Serialiser : ScriptableObject
	{
		public abstract void Serialise(object key, object data);
		public abstract T Deserialise<T>(object key, T target);
	}
}