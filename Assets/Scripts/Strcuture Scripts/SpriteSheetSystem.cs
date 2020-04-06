using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{

    public class SpriteSheetSystem : System_Structure
    {
        public static bool spriteSheetEnd = false;

        static AnimatorOverrideController animOverride;

        public static IEnumerator ManageSpriteSheet(Element element, List<AnimationClip> Clip, Animator spriteSheetAnimator, GameObject SpriteSheetManager)
        {
            print("SpriteSheet Start");
            yield return new WaitForSeconds(element.spriteSheetsManager.delayTime);

            SpriteSheetManager.GetComponent<Animator>().enabled = true;

            animOverride = new AnimatorOverrideController(spriteSheetAnimator.runtimeAnimatorController);
            spriteSheetAnimator.runtimeAnimatorController = animOverride;

            int index = (int)element.spriteSheetsManager.spriteName;
            animOverride["DefaultState"] = Clip[index];

            AnimatorStateReseter.ResetCurrentAnimatorState(spriteSheetAnimator, 0, 0);

            yield return new WaitForSeconds(Clip[index].length);
            spriteSheetEnd = true;
            print("SpriteSheet End");
        }

        public static void CheckSpriteSheetReset(Element element, GameObject SpriteSheetManager, SpriteRenderer SpriteRenderer, Sprite EmptySprite)
        {
            if (element.spriteSheetsManager.reset)
            {
                SpriteSheetReset(SpriteSheetManager, SpriteRenderer, EmptySprite);
            }
        }

        public static void SpriteSheetReset(GameObject SpriteSheetManager, SpriteRenderer SpriteRenderer, Sprite EmptySprite)
        {
            print("Reset SpriteSheet");
            SpriteSheetManager.GetComponent<Animator>().enabled = false;
            SpriteRenderer.sprite = EmptySprite;
        }
    }

}
