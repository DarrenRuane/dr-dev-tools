using UnityEngine;
using UnityEngine.UI;
using DRDevTools.TypeAdapters.Variables;

namespace DRDevTools.Utility
{
    [ExecuteInEditMode]
    public class SliderSetter : MonoBehaviour
    {
        public FloatVariable Variable;
        public Slider Slider;

        private void Update()
        {
            if (Slider != null && Variable != null)
                Slider.value = Variable.Value;
        }
    }
}