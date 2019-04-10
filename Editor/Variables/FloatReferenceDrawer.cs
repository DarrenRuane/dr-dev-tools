using UnityEditor;
using DRDevTools.TypeAdapters.References;

namespace DRDevTools.Editor.Variables
{
    [CustomPropertyDrawer(typeof(FloatReference))]
    public class FloatReferenceDrawer : VariableReferenceDrawer { }
}