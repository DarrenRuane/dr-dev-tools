using System.Collections.Generic;
using UnityEngine;
using DRDevTools.Variables;

namespace DRDevTools.Events
{
    [CreateAssetMenu(menuName = "Events/Vector2")]
    public class Vector2GameEvent : ScriptableObject
    {
        private readonly List<Vector2GameEventListener> eventListeners = new List<Vector2GameEventListener>();

        public void Raise(Vector2Variable vector)
        {
            for (var i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(vector);
        }

        public void RegisterListener(Vector2GameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(Vector2GameEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}