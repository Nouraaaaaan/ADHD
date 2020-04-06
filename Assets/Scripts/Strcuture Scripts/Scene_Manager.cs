using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    /// <summary>
    /// This Script to manage the Scenario of the Scene 
    /// </summary>
    public class Scene_Manager : System_Structure //  i am using partial so everyone can create his/her own class with different implementation 
    {
        private void Start()
        {
            CheatingFunction(System_Structure.cheatingIndex);
            Animator_override_helper();

            StartCoroutine(LoadfromXML());
        }

        private void CheatingFunction(int value)
        {
            System_Structure.elementIndex = value;
        }

        /// <summary>
        /// Responsible for calling all element parts (text, audio, image, spriteSheet, question, 3dModel, character, timeline and transition). 
        /// </summary>
        IEnumerator LoadfromXML()
        {
            Element element = Xml_Manager.ins.subject.lessons[System_Structure.lessonIndex].elements[System_Structure.elementIndex];

            #region Text Area 

            if (element.textManager.exist)
            {
                StartCoroutine(TextSystem.ManageText(element));
            }

            #endregion

            #region Audio Area 

            if (element.audioManager.exist)
            {
                yield return StartCoroutine(AudioSystem.ManageAudio(element));
            }

            #endregion

            #region Image Area 

            if (element.imageManager.exist)
            {
                StartCoroutine(ImageSystem.ManageImage(element, list_sprite, list_image));
            }

            #endregion

            #region SpriteSheet Area 

            if (element.spriteSheetsManager.exist)
            {
                StartCoroutine(SpriteSheetSystem.ManageSpriteSheet(element, AnimationClips_List, SpriteSheet_Anim, SpriteSheetManager));
            }

            #endregion

            #region Questions Area 

            //if (Element[Transition_index].questionManager.exist)
            //{
            //loading assetbundle
            //QuestionAnswer_System.QuestionAnswer_manager(Element[Transition_index].questionManager.URL, Element[Transition_index].questionManager.instantiationPoint);
            //}

            #endregion

            #region 3D Model Area 

            if (element.model3DManager.exist)
            {
                StartCoroutine(Model3dSystem.Model3dManager(element));
            }

            #endregion

            #region Characters Area 

            //Need to Check Existance (Later)
            StartCoroutine(CharacterSystem.ins.CharacterManager(element));

            #endregion

            #region TimeLine Area 

            if (element.timelineManager.exist)
            {
                StartCoroutine(TimelineSystem.TimelineManager(element, playableDirector, playableAssets));
            }

            #endregion

            #region Transition Area 

            if (element.transitionType == TransitionType.Auto) // Transition is Auto 
            {
                yield return StartCoroutine(CheckElementPartsEnding(element));
                ResetBooleans();
                CheckElementsPartsReset();

                System_Structure.elementIndex++;
                print("Increase, Now Transition_Index= " + System_Structure.elementIndex);

                StartCoroutine(LoadfromXML());
            }
            else
            {
                //for now make the last element empty
                //StartCoroutine(LoadfromXML());
                ResetBooleans();
            }

            #endregion
        }

        public static IEnumerator CheckElementPartsEnding(Element element)
        {
            if (element.textManager.exist) yield return new WaitUntil(() => TextSystem.textEnd == true);
            if (element.audioManager.exist) yield return new WaitUntil(() => AudioSystem.audioEnd == true);
            if (element.imageManager.exist) yield return new WaitUntil(() => ImageSystem.ImageEnd == true);
            if (element.spriteSheetsManager.exist) yield return new WaitUntil(() => SpriteSheetSystem.spriteSheetEnd == true);
            if (element.model3DManager.exist) yield return new WaitUntil(() => Model3dSystem.model3DEnd == true);
            if (element.characterManager.exist) yield return new WaitUntil(() => CharacterSystem.characterEnd == true);
            if (element.timelineManager.exist) yield return new WaitUntil(() => TimelineSystem.timelineEnd == true);
        }

        private void Animator_override_helper()
        {
            print("Characters Animators Num. " + charactersAnimators.Count);

            for (int i = 0; i < charactersAnimators.Count; i++)
            {
                animatoroveridecharacter[i] = new AnimatorOverrideController(charactersAnimators[i].runtimeAnimatorController);
                charactersAnimators[i].runtimeAnimatorController = animatoroveridecharacter[i];
            }
        }

        #region Reset Area 

        private void ResetBooleans()
        {
            TextSystem.textEnd = false;
            AudioSystem.audioEnd = false;
            ImageSystem.ImageEnd = false;
            SpriteSheetSystem.spriteSheetEnd = false;
            Model3dSystem.model3DEnd = false;
            CharacterSystem.characterEnd = false;
            TimelineSystem.timelineEnd = false;
        }

        void CheckElementsPartsReset()
        {
            Element element = Xml_Manager.ins.subject.lessons[System_Structure.lessonIndex].elements[System_Structure.elementIndex];

            TextSystem.CheckTextReset(element, textDisplay);
            //Image_System.CheckImageReset(Element[Transition_index]);
            SpriteSheetSystem.CheckSpriteSheetReset(element, SpriteSheetManager, SpriteRenderer, System_Structure.Ins.emptySprite);
            Model3dSystem.CheckModel3DReset(element);
        }

        #endregion

    }
}