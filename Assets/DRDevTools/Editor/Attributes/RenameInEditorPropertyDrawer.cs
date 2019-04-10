using UnityEditor;
using UnityEngine;
using DRDevTools.Utility.Attributes;

namespace DRDevTools.Editor.Attributes
{
    [CustomPropertyDrawer(typeof(RenameInEditorAttribute))]
    public class RenameInEditorPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) =>
            EditorGUI.PropertyField(position, property, new GUIContent((attribute as RenameInEditorAttribute)?.NewName));
    }
}
