using UnityEditor;
using UnityEngine;
using DRDevTools.Events;

namespace DRDevTools.Editor.Events
{
    [CustomEditor(typeof(GameEvent))]
    public class EventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            if (target is GameEvent gameEvent)
            {
                if (GUILayout.Button("Raise"))
                    gameEvent.Raise();
            }
        }
    }
}