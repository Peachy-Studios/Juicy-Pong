using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MaterialColor)), CanEditMultipleObjects]
public class MaterialColorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        //DrawDefaultInspector();

        MaterialColor materialColor = (MaterialColor) target;

        if(GUILayout.Button("Swap"))
        {
            materialColor.SwapColor();
        }
    }
}
