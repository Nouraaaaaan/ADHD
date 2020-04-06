//using System.Collections.Generic;
//using System.Xml.Serialization;
//using System.IO;
//using UnityEditor;
//using UnityEngine;
//using System;
//namespace Valve.VR.InteractionSystem.Sample
//{
//    [CustomPropertyDrawer(typeof(ImageManager))]
//    public class ImageItemDrawer : PropertyDrawer
//    {
//        public static int SelectedImageIndex = 0;
//        public static List<string> ImageName = new List<string>();
//        public static string[] ImageNameArray;
//        GUIContent[] DatabaseGUIImageContents;
//        DirectoryInfo DirectoryInfoImage;
//        FileInfo[] allImageFiles;

//        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
//        {
//            //return EditorGUIUtility.singleLineHeight * 6 + 6;
//            return property.isExpanded ? EditorGUIUtility.singleLineHeight * 5 + 5 : EditorGUIUtility.singleLineHeight;
//        }

//        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) //OnGUI is called for rendering and handling GUI events.
//        {
//            Rect foldoutPos = position;
//            foldoutPos.width = EditorGUIUtility.labelWidth; //Set the width of the foldout label 
//            property.isExpanded = EditorGUI.Foldout(foldoutPos, property.isExpanded, GUIContent.none);

//            //  OnGUI is called every time you press on the inspector
//            Debug.Log("Image Editor's OnGUI is called");

//            //Read Audio data from Stremming Assets
//            DirectoryInfoImage = new DirectoryInfo(Application.streamingAssetsPath + "/Images/");
//            allImageFiles = DirectoryInfoImage.GetFiles("*.*");

//            //fill-in the list     
//            for (int i = 0; i < allImageFiles.Length; i += 2)
//            {
//                ImageName.Add(allImageFiles[i].Name);
//            }

//            //change array to list.
//            ImageNameArray = ImageName.ToArray();
//            Debug.Log("OnGUILoadImages");

//            DatabaseGUIImageContents = Array.ConvertAll(ImageNameArray, i => new GUIContent(i));

//            //Begin a new property
//            EditorGUI.BeginProperty(position, label, property);
//            EditorGUI.LabelField(position, label);

//            //Calculating Rect Dimensions
//            var imageExistValue = new Rect(position.x, position.y + 18, position.width, 16);
//            var imageNameValue = new Rect(position.x, position.y + 36, position.width, 16);
//            var imagePositionValue = new Rect(position.x, position.y + 54, position.width, 16);
//            var delayTimeValue = new Rect(position.x, position.y + 72, position.width, 16);

//            EditorGUI.indentLevel++;

//            if (property.isExpanded)
//            {
//                Debug.Log("Property is Expanded");

//                //Get Relative data by name
//                EditorGUI.PropertyField(imageExistValue, property.FindPropertyRelative("exist"));
//                EditorGUI.PropertyField(delayTimeValue, property.FindPropertyRelative("delayTime"));
//                EditorGUI.PropertyField(imagePositionValue, property.FindPropertyRelative("imagePosition"));

//                property = property.FindPropertyRelative("imageName");

//                EditorGUI.BeginChangeCheck();

//                int selectedIndex = Array.IndexOf(ImageNameArray, property.stringValue);
//                selectedIndex = EditorGUI.Popup(imageNameValue, label, selectedIndex, DatabaseGUIImageContents);

//                //Show the selected value
//                if (EditorGUI.EndChangeCheck())
//                {
//                    property.stringValue = ImageNameArray[selectedIndex];
//                }
//                SelectedImageIndex = selectedIndex;

//            }

//            //End the property
//            EditorGUI.EndProperty();

//        }
//    }
//}