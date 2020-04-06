using UnityEngine;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Video;
using UnityEngine.Networking;
using System.Collections;
namespace Valve.VR.InteractionSystem.Sample
{
    /// <summary>
    /// This Script target is to get the Audio from Streaming Assets , to load inside the scene
    /// </summary>
    public class LoadAudio : MonoBehaviour
    {
        public Scene_Manager scene_Manager;
        public List<string> audioName;
        public static List<string> audioNameList;

        public static bool loadingAudioDone;
        string audioPath, finalAudioPath;

        DirectoryInfo audioDirectoryInfo;
        FileInfo[] allFiles;

        private void Awake()
        {
            audioPath = "file://" + Application.streamingAssetsPath + "/Sound/";//file streaming path 
            audioDirectoryInfo = new DirectoryInfo(Application.streamingAssetsPath + "/Sound/");
            allFiles = audioDirectoryInfo.GetFiles("*.*");

            StartCoroutine(LoadAudioCoroutine());
        }

        private IEnumerator LoadAudioCoroutine()
        {
            for (int i = 0; i < allFiles.Length; i += 2)
            {
                audioName.Add(allFiles[i].Name);
            }

            audioNameList = audioName;

            for (int i = 0; i < audioName.Count; i++)
            {
                finalAudioPath = string.Format(audioPath + "{0}", audioName[i]);
                WWW localFile = new WWW(finalAudioPath);
                yield return localFile;

                // audioClips List Deleted
                // scene_Manager.audioClips.Add(localFile.GetAudioClip());
            }

            loadingAudioDone = true;
        }

    }
}