using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class CharacterAnimationSystem : CharacterSystem
    {
        /// <summary>
        /// Make all characters idle except the choosen one depend on character exist boolean 
        /// </summary>
        public static void IdleCharacters(bool characterExist)
        {
            for (int i = 0; i < System_Structure.Ins.charactersAnimators.Count; i++)
            {
                if ((characterExist && i != characterIndex) || !characterExist)
                    System_Structure.Ins.animatoroveridecharacter[i][System_Structure.Ins.overrideClipsNames] = System_Structure.Ins.Idle_Animations[i];
            }
        }

        public static void PlayAnimationClip(int animClipIndex, int characterindex)
        {
            for (int i = 0; i < System_Structure.Ins.animatoroveridecharacter.Count; i++)
            {
                System_Structure.Ins.animatoroveridecharacter[characterindex][System_Structure.Ins.overrideClipsNames] = System_Structure.Ins.Animation_Clips[animClipIndex];
                AnimatorStateReseter.ResetCurrentAnimatorState(character.GetComponent<Animator>(), 0, 0);
            }
        }

        /// <summary>
        /// Make character look at next waypoint and move to it while walk animation playing
        /// </summary>
        public static IEnumerator MoveCharacterToNextWaypoint()
        {
            int pos = (int)Xml_Manager.ins.subject.lessons[System_Structure.lessonIndex].elements[System_Structure.elementIndex].characterManager.characterMovement.waypoints[moveIndex].waypoint;
            while (character.position != System_Structure.Ins.waypoints[pos].transform.position)
            {
                character.LookAt(System_Structure.Ins.waypoints[pos].transform.position);
                character.position = Vector3.MoveTowards(character.position, System_Structure.Ins.waypoints[pos].transform.position, 1.5f * Time.deltaTime); //Move
                System_Structure.Ins.animatoroveridecharacter[0][System_Structure.Ins.overrideClipsNames] = System_Structure.Ins.Walk_Animations[characterIndex]; //Animate Walk

                yield return new WaitForSeconds(.005f);
            }
        }
    }
}