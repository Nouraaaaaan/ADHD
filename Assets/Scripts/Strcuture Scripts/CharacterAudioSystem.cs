using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class CharacterAudioSystem : CharacterSystem
    {
        /// <summary>
        /// Play audioClip from given path. 
        /// </summary>
        /// <param name="audioPath"></param>
        /// <returns>AudioClipLength.</returns>
        public static float PlayAudioClip(string audioPath)
        {
            //Check AudioClip component existance.
            if (character.gameObject.GetComponent<AudioSource>() == null)
            {
                character.gameObject.AddComponent<AudioSource>();
            }

            //Get the audio file from the path
            AudioClip audioClip = Resources.Load("Audio/" + audioPath) as AudioClip;

            character.gameObject.GetComponent<AudioSource>().clip = audioClip;
            character.gameObject.GetComponent<AudioSource>().Play();

            return audioClip.length;
        }

    }
}