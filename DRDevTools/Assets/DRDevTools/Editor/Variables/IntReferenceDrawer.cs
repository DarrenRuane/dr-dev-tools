using UnityEditor;
using DRDevTools.Variables;

namespace DRDevTools.Editor.Variables
{
    [CustomPropertyDrawer(typeof(IntReference))]
    public class IntReferenceDrawer : VariableReferenceDrawer { }
}