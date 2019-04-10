using UnityEngine;
using UnityEngine.Events;

namespace DRDevTools.Utility
{
    public class UnityEventRaiser : MonoBehaviour
    {
        public UnityEvent OnEnableEvent;

        public void OnEnable() => OnEnableEvent.Invoke();
    }
}