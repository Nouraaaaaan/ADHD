using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    public class ImagePos : MonoBehaviour
    {
        public static void ChangeImagePosition(RectTransform imageRectTransform, ImagePosition imagePosition)
        {
            switch (imagePosition)
            {
                case ImagePosition.topLeft:
                    TopLeft(imageRectTransform);
                    break;
                case ImagePosition.topMiddle:
                    TopMiddle(imageRectTransform);
                    break;
                case ImagePosition.topRight:
                    TopRight(imageRectTransform);
                    break;
                case ImagePosition.middleLeft:
                    MiddleLeft(imageRectTransform);
                    break;
                case ImagePosition.middle:
                    Middle(imageRectTransform);
                    break;
                case ImagePosition.middleRight:
                    MiddleRight(imageRectTransform);
                    break;
                case ImagePosition.bottomLeft:
                    BottomLeft(imageRectTransform);
                    break;
                case ImagePosition.bottomMiddle:
                    BottomMiddle(imageRectTransform);
                    break;
                case ImagePosition.bottomRight:
                    BottomRight(imageRectTransform);
                    break;
                default:
                    break;
            }
        }

        //------------Top-------------------
        static void TopLeft(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(0, 1);
            imageRectTransform.anchorMax = new Vector2(0, 1);
            imageRectTransform.pivot = new Vector2(0, 1);

            imageRectTransform.anchoredPosition = new Vector3(0, imageRectTransform.rect.height, 0);
        }

        static void TopMiddle(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(0.5f, 1);
            imageRectTransform.anchorMax = new Vector2(0.5f, 1);
            imageRectTransform.pivot = new Vector2(0.5f, 1);

            imageRectTransform.anchoredPosition = new Vector3(0, imageRectTransform.rect.height, 0);
        }

        static void TopRight(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(1, 1);
            imageRectTransform.anchorMax = new Vector2(1, 1);
            imageRectTransform.pivot = new Vector2(1, 1);

            imageRectTransform.anchoredPosition = new Vector3(0, imageRectTransform.rect.height, 0);
        }

        //------------Middle-------------------
        static void MiddleLeft(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(0, 0.5f);
            imageRectTransform.anchorMax = new Vector2(0, 0.5f);
            imageRectTransform.pivot = new Vector2(0, 0.5f);

            imageRectTransform.anchoredPosition = new Vector3(-imageRectTransform.rect.height, 0, 0);
        }

        static void Middle(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            imageRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            imageRectTransform.pivot = new Vector2(0.5f, 0.5f);

            imageRectTransform.anchoredPosition = new Vector3(0, 0, 0);
        }

        static void MiddleRight(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(1, 0.5f);
            imageRectTransform.anchorMax = new Vector2(1, 0.5f);
            imageRectTransform.pivot = new Vector2(1, 0.5f);

            imageRectTransform.anchoredPosition = new Vector3(imageRectTransform.rect.height, 0, 0);
        }

        //------------Bottom-------------------
        static void BottomLeft(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(0, 0);
            imageRectTransform.anchorMax = new Vector2(0, 0);
            imageRectTransform.pivot = new Vector2(0, 0);

            imageRectTransform.anchoredPosition = new Vector3(0, -imageRectTransform.rect.height, 0);
        }

        static void BottomMiddle(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(0.5f, 0);
            imageRectTransform.anchorMax = new Vector2(0.5f, 0);
            imageRectTransform.pivot = new Vector2(0.5f, 0);

            imageRectTransform.anchoredPosition = new Vector3(0, -imageRectTransform.rect.height, 0);
        }

        static void BottomRight(RectTransform imageRectTransform)
        {
            imageRectTransform.anchorMin = new Vector2(1, 0);
            imageRectTransform.anchorMax = new Vector2(1, 0);
            imageRectTransform.pivot = new Vector2(1, 0);

            imageRectTransform.anchoredPosition = new Vector3(0, -imageRectTransform.rect.height, 0);
        }
    }
}