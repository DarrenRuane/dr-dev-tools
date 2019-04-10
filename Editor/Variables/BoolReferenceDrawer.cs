using UnityEditor;
using DRDevTools.TypeAdapters.References;

namespace DRDevTools.Editor.Variables
{
    [CustomPropertyDrawer(typeof(BoolReference))]
    public class BoolReferenceDrawer : VariableReferenceDrawer { }
}