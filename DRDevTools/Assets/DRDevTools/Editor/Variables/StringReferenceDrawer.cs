using UnityEditor;
using DRDevTools.Variables;

namespace DRDevTools.Editor.Variables
{
    [CustomPropertyDrawer(typeof(StringReference))]
    public class StringReferenceDrawer : VariableReferenceDrawer { }
}