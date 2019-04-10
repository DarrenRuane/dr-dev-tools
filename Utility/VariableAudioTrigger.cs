using UnityEngine;
using DRDevTools.TypeAdapters.Variables;
using DRDevTools.TypeAdapters.References;

namespace DRDevTools.Utility
{
    public class VariableAudioTrigger : MonoBehaviour
    {
        public FloatVariable Variable;

        public AudioSource AudioSource;

        public IntReference LowThreshold;

        private void Update()
        {
            if (Variable.Value < LowThreshold)
            {
                if (!AudioSource.isPlaying)
                    AudioSource.Play();
            }
            else
            {
                if (AudioSource.isPlaying)
                    AudioSource.Stop();
            }
        }
    }
}