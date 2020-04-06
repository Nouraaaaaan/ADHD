using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
namespace Valve.VR.InteractionSystem.Sample
{
    public class AudioSystem : System_Structure
    {
        public static bool audioEnd;

        public static IEnumerator ManageAudio(Element element)
        {
            print("Audio Start");
            yield return new WaitForSeconds(element.audioManager.delayTime);

            //Get the audio file from the path
            AudioClip audioClip = Resources.Load("Audio/" + element.audioManager.audio) as AudioClip;

            Ins.audiosource.clip = audioClip;
            Ins.audiosource.Play();

            yield return new WaitForSeconds(audioClip.length);
            audioEnd = true;
            print("Audio End");
        }

    }
}