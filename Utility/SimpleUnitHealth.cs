using UnityEngine;
using DRDevTools.TypeAdapters.Variables;
using DRDevTools.TypeAdapters.References;

namespace DRDevTools.Utility
{
    public class SimpleUnitHealth : MonoBehaviour
    {
        public FloatVariable Health;

        public IntReference StartingHealth;

        public bool ResetHealth;
        
        private void Start()
        {
            if (ResetHealth)
                Health.SetValue(StartingHealth);
        }

        private void OnTriggerEnter(Collider other)
        {
            var damage = other.gameObject.GetComponent<DamageDealer>();

            if (damage != null)
                Health.ApplyChange(-damage.DamageAmount);
        }
    }
}