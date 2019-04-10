using System;
using UnityEngine;
using UnityEngine.Events;

namespace DRDevTools.Events
{
    public class Vector2GameEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public Vector2GameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public Vector2UnityEvent Response;

        private void OnEnable() => Event.RegisterListener(this);

        private void OnDisable() => Event.UnregisterListener(this);

        public void OnEventRaised(Vector2 vector) => Response.Invoke(vector);
    }

    [Serializable]
    public class Vector2UnityEvent : UnityEvent<Vector2> { }
}