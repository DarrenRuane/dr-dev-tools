using System.Collections.Generic;
using UnityEngine;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.Events
{
    [CreateAssetMenu(menuName = "Events/Vector3")]
    public class Vector3GameEvent : ScriptableObject
    {
        private readonly List<Vector3GameEventListener> eventListeners = new List<Vector3GameEventListener>();

        public void Raise(Vector3Variable vector)
        {
            for (var i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(vector);
        }

        public void RegisterListener(Vector3GameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(Vector3GameEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}