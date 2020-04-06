using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class CharacterSystem : Scene_Manager
    {
        public static Transform character;
        public static bool characterEnd;
        public static int characterIndex;

        public static CharacterSystem ins = new CharacterSystem();

        private void Start()
        {
            ins = this;
        }

        /// <summary>
        /// Describe what happen to Characters in One Element 
        /// </summary>
        public IEnumerator CharacterManager(Element element)
        {
            if (element.characterManager.exist)
            {
                print("Character Start");
                yield return new WaitForSeconds(element.characterManager.delayTime);

                characterIndex = (int)element.characterManager.character;
                character = System_Structure.Ins.Helper_characters[characterIndex].transform;

                CharacterAnimationSystem.IdleCharacters(true);

                if (element.characterManager.characterMovement.move)
                {
                TRYAGAIN:

                    while (CharacterAnimationSystem.MoveCharacterToNextWaypoint().MoveNext())
                    {
                        yield return null;
                    }

                    // When character reach to next waypoint
                    int nextWaypointIndex = (int)element.characterManager.characterMovement.waypoints[moveIndex].waypoint;
                    if (character.position == System_Structure.Ins.waypoints[nextWaypointIndex].transform.position)
                    {
                        print("Character moving index = " + moveIndex);
                        int animIndnx = (int)element.characterManager.characterMovement.waypoints[moveIndex].animation;

                        LookAt(character, (int)element.characterManager.characterMovement.waypoints[moveIndex].lookAt);
                        CharacterAnimationSystem.PlayAnimationClip(animIndnx, characterIndex);

                        if (element.characterManager.characterMovement.waypoints[moveIndex].audio.exist)
                        {
                            string audioPath = element.characterManager.characterMovement.waypoints[moveIndex].audio.audio;
                            float audioClipLength = CharacterAudioSystem.PlayAudioClip(audioPath);
                            yield return new WaitForSeconds(audioClipLength);
                        }
                        else
                        {
                            float animClipLength = System_Structure.Ins.Animation_Clips[animIndnx].length;
                            yield return new WaitForSeconds(animClipLength);
                        }

                        // check that move index got the final point or still 
                        if (moveIndex == (int)element.characterManager.characterMovement.waypoints.Count - 1)
                        {
                            characterEnd = true;// if yes , don't do anything more
                            print("Character End");
                            moveIndex = 0;
                        }
                        else
                        {
                            moveIndex++;
                            goto TRYAGAIN;
                        }
                    }
                }
                else
                {
                    int charAnimIndex = (int)element.characterManager.animation;
                    float animClipLength = System_Structure.Ins.Animation_Clips[charAnimIndex].length;

                    LookAt(character, (int)element.characterManager.lookAt);
                    CharacterAnimationSystem.PlayAnimationClip(charAnimIndex, characterIndex);

                    if (element.characterManager.audio.exist)
                    {
                        float audioClipLength = CharacterAudioSystem.PlayAudioClip(element.characterManager.audio.audio);
                        yield return new WaitForSeconds(audioClipLength);

                    }
                    else
                        yield return new WaitForSeconds(animClipLength);

                    characterEnd = true;
                    print("Character End");
                }
            }
            else
            {
                CharacterAnimationSystem.IdleCharacters(false);
            }
        }

        public static void LookAt(Transform character, int objectToLookAtIndex)
        {
            Vector3 targetPos = System_Structure.Ins.lookAtPositions[objectToLookAtIndex].transform.position;
            float distanceBetweenCharacters = Vector3.Dot(character.up, targetPos - character.position);
            Vector3 pointOnPlane = targetPos - (character.up * distanceBetweenCharacters);
            character.LookAt(pointOnPlane, character.up);
        }
    }
}
