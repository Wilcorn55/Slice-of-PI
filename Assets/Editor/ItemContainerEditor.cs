using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(ItemContainer))]
public class ItemContainerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ItemContainer container = target as ItemContainer;
        if(GUILayout.Button("Clear container")) 
        {
            for(int i = 0; i < container.Slots.Count; i++) 
            {
                container.Slots[i].item = null;
                container.Slots[i].count = 0;
            }
        }
        DrawDefaultInspector();
    }


}
