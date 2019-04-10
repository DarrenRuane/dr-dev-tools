using UnityEngine;

namespace DRDevTools.Utility.Attributes
{
    public class RenameInEditorAttribute : PropertyAttribute
    {
        public RenameInEditorAttribute(string name) => NewName = name;

        public string NewName { get; }
    }
}