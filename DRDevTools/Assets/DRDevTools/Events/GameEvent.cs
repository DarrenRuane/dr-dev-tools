using System.Collections.Generic;
using UnityEngine;

namespace DRDevTools.Events
{
    [CreateAssetMenu(menuName = "Events/Void")]
    public class GameEvent : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify when it is raised.
        /// </summary>
        private readonly List<GameEventListener> eventListeners = new List<GameEventListener>();

        public void Raise()
        {
            // Start at the end and go backwards in case listeners unregister after the event is raised
            for(var i = eventListeners.Count -1; i >= 0; i--)
                eventListeners[i].OnEventRaised();
        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}