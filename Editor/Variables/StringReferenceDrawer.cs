using UnityEditor;
using DRDevTools.TypeAdapters.References;

namespace DRDevTools.Editor.Variables
{
    [CustomPropertyDrawer(typeof(StringReference))]
    public class StringReferenceDrawer : VariableReferenceDrawer { }
}