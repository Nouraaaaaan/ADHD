using UnityEngine;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Video;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem.Sample
{
    /// <summary>
    /// This Script target is to get the Audio from Streaming Assets , to load inside the scene
    /// </summary>
    public class LoadImages : MonoBehaviour
    {
        public Scene_Manager scene_Manager;
        public static bool loadingDone;

        public List<string> imagesName;
        string imagePath, finalImagePath;

        Sprite sprite;
        Texture2D texture;

        DirectoryInfo imagesDirectoryInfo;
        FileInfo[] allFiles;

        private void Awake()
        {
            imagePath = "file://" + Application.streamingAssetsPath + "/Images/";//file streaming path 
            imagesDirectoryInfo = new DirectoryInfo(Application.streamingAssetsPath + "/Images/");
            allFiles = imagesDirectoryInfo.GetFiles("*.*");

            StartCoroutine(LoadImageCouroutine());
        }

        IEnumerator LoadImageCouroutine()
        {
            for (int i = 0; i < allFiles.Length; i += 2)
            {
                imagesName.Add(allFiles[i].Name);
            }

            for (int i = 0; i < imagesName.Count; i++)
            {
                finalImagePath = string.Format(imagePath + "{0}", imagesName[i]);
                WWW localFile = new WWW(finalImagePath);
                yield return localFile;

                texture = localFile.texture;
                sprite = Sprite.Create(texture as Texture2D, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
                scene_Manager.list_sprite.Add(sprite);
            }

            loadingDone = true;
            print("LOADINGGG" + loadingDone);
        }
    }
}