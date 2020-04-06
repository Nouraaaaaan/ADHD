using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using SFB;
namespace Valve.VR.InteractionSystem.Sample
{
    public class AudioPanel : MonoBehaviour
    {
        public ArabicText choosenAudio;
        public InputField delayTime;

        string fullPath, audioPath;

        public static AudioPanel Instance
        {
            get;
            private set;
        }

        private void Start()
        {
            // Singlton
            Instance = this;
        }

        /// <summary>
        /// This function called by Browse button to get the audio path.
        /// It can get the audio inside the audio file only.
        /// </summary>
        public void Browse()
        {
            audioPath = Application.dataPath + "/Resources/Audio";

            var extensions = new[] { new ExtensionFilter("Choose Your Audio", "mp3", "ogg", "wav") };
            fullPath = FileBrowser.GetFullPath(StandaloneFileBrowser.OpenFilePanel("Open File", audioPath, extensions, false));

            choosenAudio.Text = FileBrowser.GetFileSmallPath(audioPath, fullPath);
        }

        /// <summary>
        /// Save the audio part values to the xml file.
        /// AudioPart: exist, audio, delayTime.
        /// </summary>
        public void SaveAudio()
        {
            Element element = Xml_Manager.ins.subject.lessons[System_Structure.lessonIndex].elements[System_Structure.elementIndex];

            if (choosenAudio.Text != "")
            {
                element.audioManager.exist = true;
                element.audioManager.audio = choosenAudio.Text;
                element.audioManager.delayTime = (delayTime.text == "") ? 0 : float.Parse(delayTime.text);
            }
            else
                element.audioManager.exist = false;

            Xml_Manager.ins.SaveItems();
        }

        /// <summary>
        /// Load the audio part values from the xml file.
        /// AudioPart: exist, audio, delayTime.
        /// </summary>
        public void LoadAudio(Element element)
        {
            if (element.audioManager.exist)
            {
                choosenAudio.Text = element.audioManager.audio;
                delayTime.text = element.audioManager.delayTime.ToString();
            }
            else
            {
                choosenAudio.Text = "";
                delayTime.text = "";
            }
        }
    }
}
