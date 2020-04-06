using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    public class TextSystem : MonoBehaviour
    {
        public static bool textEnd;

        public static IEnumerator ManageText(Element element)
        {
            print("Text Start");
            yield return new WaitForSeconds(element.textManager.delayTime);

            for (int i = 0; i < (int)element.textManager.textItems.Count; i++)
            {
                System_Structure.Ins.textDisplay[(int)element.textManager.textItems[i].position].GetComponent<ArabicText>().Text = element.textManager.textItems[i].text;
                System_Structure.Ins.textDisplay[(int)element.textManager.textItems[i].position].GetComponent<Text>().color = new Color(element.textManager.textItems[i].color.x / 255, element.textManager.textItems[i].color.y / 255, element.textManager.textItems[i].color.z / 255, element.textManager.textItems[i].color.w);
            }

            textEnd = true;
            print("Text End");
        }

        public static void CheckTextReset(Element element, List<Text> textList)
        {
            if (element.textManager.reset)
            {
                TextReset(textList);
            }
        }

        static void TextReset(List<Text> textList)
        {
            foreach (var item in textList)
                item.text = "";
        }

    }
}