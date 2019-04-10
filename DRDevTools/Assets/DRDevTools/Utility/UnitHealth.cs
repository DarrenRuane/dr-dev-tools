using UnityEngine;
using UnityEngine.Events;
using DRDevTools.Variables;

namespace DRDevTools.Utility
{
    public class UnitHealth : MonoBehaviour
    {
        public FloatVariable Health;
        public IntReference StartingHealth;

        public bool ResetHealth;
        public UnityEvent DamageEvent;
        public UnityEvent DeathEvent;

        private void Start()
        {
            if (ResetHealth)
                Health.SetValue(StartingHealth);
        }

        private void OnTriggerEnter(Collider other)
        {
            var damage = other.gameObject.GetComponent<DamageDealer>();

            if (damage != null)
            {
                Health.ApplyChange(-damage.DamageAmount);
                DamageEvent.Invoke();
            }

            if (Health.Value <= 0.0f)
                DeathEvent.Invoke();
        }
    }
}