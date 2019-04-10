using UnityEngine;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.Utility
{
    /// <inheritdoc/>
    /// <summary>
    /// Takes a FloatVariable and sends its value to an Animator parameter 
    /// every frame on Update.
    /// </summary>
    public class AnimatorParameterSetter : MonoBehaviour
    {
        /// <summary>
        /// Animator Hash of ParameterName, automatically generated.
        /// </summary>
        [SerializeField]
        private int parameterHash;

        [Tooltip("Variable to read from and send to the Animator as the specified parameter.")]
        public FloatVariable Variable;

        [Tooltip("Animator to set parameters on.")]
        public Animator Animator;

        [Tooltip("Name of the parameter to set with the value of Variable.")]
        public string ParameterName;
        
        private void OnValidate() => parameterHash = Animator.StringToHash(ParameterName);

        private void Update() => Animator.SetFloat(parameterHash, Variable.Value);
    }
}