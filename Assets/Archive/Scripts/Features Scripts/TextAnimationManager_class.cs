//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//namespace Valve.VR.InteractionSystem.Sample
//{
//    public class TextAnimationManager_class : MonoBehaviour
//    {
//        float smoothing = 1;
//        float maxTextScale = 2, minTextScale = 0.5f;

//        /// <summary>
//        /// This Function move text between two textPositions"enums". 
//        /// </summary>
//        public IEnumerator Move(Transform startingPoint, Vector3 endingPoint)
//        {
//            while (startingPoint.position != endingPoint)
//            {
//                startingPoint.position = Vector3.MoveTowards(startingPoint.position, endingPoint, smoothing * Time.deltaTime);
//                yield return null;
//            }
//        }
        
//        /// <summary>
//        /// This Function ScaleUp text from its current scale to maxTextScale. 
//        /// </summary>
//        public IEnumerator ScaleUp(Transform textDisplay)
//        {
//            while (textDisplay.localScale.magnitude != maxTextScale)
//            {
//                textDisplay.localScale = Vector3.MoveTowards(textDisplay.localScale, new Vector3(maxTextScale, maxTextScale, maxTextScale), smoothing * Time.deltaTime);
//                yield return null;
//            }
//        }

//        /// <summary>
//        /// This Function ScaleDown text from its current scale to minTextScale. 
//        /// </summary>
//        public IEnumerator ScaleDown(Transform textDisplay)
//        {
//            while (textDisplay.localScale.magnitude != minTextScale)
//            {
//                textDisplay.localScale = Vector3.MoveTowards(textDisplay.localScale, new Vector3(minTextScale, minTextScale, minTextScale), smoothing * Time.deltaTime);
//                yield return null;
//            }
//        }

//        public IEnumerator Rotate(Transform DisplayText)
//        {
//            while (DisplayText.localEulerAngles.z <= 359)
//            {
//                DisplayText.transform.Rotate(new Vector3(0, 0, 65) * Time.deltaTime);

//                yield return null;
//            }
//        }

//    }
//}