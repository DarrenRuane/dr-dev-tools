using UnityEngine;
using UnityEngine.Audio;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.Utility
{
    public class AudioVolumeSetter : MonoBehaviour
    {
        public FloatVariable Variable;
        public AudioMixer Mixer;
        public string ParameterName = string.Empty;

        private void Update() =>
            Mixer.SetFloat(ParameterName, Variable.Value > 0.0f ? 20.0f * Mathf.Log10(Variable.Value) : -80.0f);
    }
}