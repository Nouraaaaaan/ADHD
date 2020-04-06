using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    public class ImageSystem : System_Structure
    {
        public static bool ImageEnd;

        public static IEnumerator ManageImage(Element element, List<Sprite> sprites, List<Image> images)
        {
            print("Image Start");

            yield return new WaitForSeconds(element.imageManager.delayTime);

            if ((int)element.imageManager.imagePosition <= 8)
            {
                PreviewImageDependingOnTextPosition(element, sprites, images);
            }
            else
            {
                PreviewImageWithoutTextPosition(element, sprites, images);
            }

            ImageEnd = true;
            print("Image End");
        }

        static void PreviewImageDependingOnTextPosition(Element element, List<Sprite> sprites, List<Image> images)
        {
            //images[(int)element.textManager.position].enabled = true; // Enable the text image 
            //images[(int)element.textManager.position].sprite = element.imageManager.sprite; // Give the index of sprite  to specific image 
            //ImagePos.ChangeImagePosition(images[(int)element.textManager.position].rectTransform, element.imageManager.imagePosition);
        }

        static void PreviewImageWithoutTextPosition(Element element, List<Sprite> sprites, List<Image> images)
        {
            images[(int)element.imageManager.imagePosition].enabled = true; // Enable the text image 
            images[(int)element.imageManager.imagePosition].sprite = element.imageManager.sprite; // Give the index of sprite  to specific image 
            ImagePos.ChangeImagePosition(images[(int)element.imageManager.imagePosition].rectTransform, element.imageManager.imagePosition);
        }

        public static void ImageReset(List<Image> images)
        {
            foreach (var item in images)
            {
                item.enabled = false;
                item.sprite = null;
            }
        }
    }
}