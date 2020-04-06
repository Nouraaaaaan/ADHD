using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Valve.VR.InteractionSystem.Sample
{
    public class TimelineSystem : System_Structure
    {
        public static bool timelineEnd;
        public static IEnumerator TimelineManager(Element element, PlayableDirector playableDirector, List<PlayableAsset> playableAssets)
        {
            print("Timeline Start");

            for (int i = 0; i < element.timelineManager.timelines.Count; i++)
            {
                playableDirector.playableAsset = playableAssets[(int)element.timelineManager.timelines[i]];
                playableDirector.Play();
                yield return new WaitForSeconds((float)playableAssets[(int)element.timelineManager.timelines[i]].duration);
            }

            timelineEnd = true;
            print("Timeline End");

        }
    }
}