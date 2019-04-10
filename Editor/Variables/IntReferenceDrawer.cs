using UnityEditor;
using DRDevTools.TypeAdapters.References;

namespace DRDevTools.Editor.Variables
{
    [CustomPropertyDrawer(typeof(IntReference))]
    public class IntReferenceDrawer : VariableReferenceDrawer { }
}