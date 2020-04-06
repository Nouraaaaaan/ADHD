//using System.Collections.Generic;
//using System.Xml.Serialization;
//using System.IO;
//using UnityEditor;
//using UnityEngine;
//using System;

//namespace Valve.VR.InteractionSystem.Sample
//{
//    [CustomPropertyDrawer(typeof(AudioManager))]
//    public class AudioItemDrawer : PropertyDrawer
//    {
//        //    public static List<string> audioName = new List<string>();

        //    public static string[] audioNameArray;
        //    GUIContent[] DatabaseGUIContents;


        //    DirectoryInfo audioDirectoryInfo;
        //    FileInfo[] allFiles;

        //    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        //    {
        //        //return EditorGUIUtility.singleLineHeight * 6 + 6;
        //        return property.isExpanded ? EditorGUIUtility.singleLineHeight * 4 + 4 : EditorGUIUtility.singleLineHeight;
        //    }

        //    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) //OnGUI is called for rendering and handling GUI events.
        //    {
        //        Rect foldoutPos = position;
        //        foldoutPos.width = EditorGUIUtility.labelWidth; //Set the width of the foldout label 
        //        property.isExpanded = EditorGUI.Foldout(foldoutPos, property.isExpanded, GUIContent.none);

        //        //  OnGUI is called every time you press on the inspector
        //        Debug.Log("Editor's OnGUI is called");

        //        //Read Audio data from Stremming Assets
        //        audioDirectoryInfo = new DirectoryInfo(Application.streamingAssetsPath + "/Sound/");
        //        allFiles = audioDirectoryInfo.GetFiles("*.*");

        //        //fill-in the list     
        //        for (int i = 0; i < allFiles.Length; i += 2)
        //        {
        //            audioName.Add(allFiles[i].Name);
        //        }

        //        //change array to list.
        //        audioNameArray = audioName.ToArray();

        //        DatabaseGUIContents = Array.ConvertAll(audioNameArray, i => new GUIContent(i));

        //        //Begin a new property
        //        EditorGUI.BeginProperty(position, label, property);
        //        EditorGUI.LabelField(position, label);

        //        //Calculating Rect Dimensions
        //        var audioExist = new Rect(position.x, position.y + 18, position.width, 16);
        //        var audioClipName = new Rect(position.x, position.y + 36, position.width, 16);
        //        var audioDelayTime = new Rect(position.x, position.y + 54, position.width, 16);

        //        EditorGUI.indentLevel++;

        //        if (property.isExpanded)
        //        {
        //            Debug.Log("Property is Expanded");

        //            //Get Relative data by name
        //            EditorGUI.PropertyField(audioExist, property.FindPropertyRelative("exist"));
        //            EditorGUI.PropertyField(audioDelayTime, property.FindPropertyRelative("delayTime"));

        //            property = property.FindPropertyRelative("audioClipName");

        //            EditorGUI.BeginChangeCheck();

        //            int selectedIndex = Array.IndexOf(audioNameArray, property.stringValue);
        //            selectedIndex = EditorGUI.Popup(audioClipName, label, selectedIndex, DatabaseGUIContents);

        //            //Show the selected value
        //            if (EditorGUI.EndChangeCheck())
        //            {
        //                property.stringValue = audioNameArray[selectedIndex];
        //            }

        //        }

        //        //End the property
        //        EditorGUI.EndProperty();
        //    }
    //}
//}