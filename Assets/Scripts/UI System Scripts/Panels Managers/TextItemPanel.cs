using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    public class TextItemPanel : MonoBehaviour
    {
        public static int textNumber;

        public InputField textNumberEntry;
        public Transform textItemsGrid;

        int textItemsNumber;


        /// <summary>
        /// Instantiate and destroy textItems in the UI scrollable list depending on textNumber value at runtime.
        /// </summary>
        public void UpdateTextItemsList()
        {
            if (textNumberEntry.text != "")
            {
                textNumber = int.Parse(textNumberEntry.text);
                textItemsNumber = textItemsGrid.transform.childCount -1;

                for (int i = 0; i < Mathf.Abs(textItemsNumber - textNumber); i++)
                {
                    if (textNumber > textItemsNumber)
                        ResetTextItemUI(Instantiate(textItemsGrid.GetChild(0), textItemsGrid));
                    else if (textNumber < textItemsNumber)
                        Destroy(textItemsGrid.GetChild(textItemsNumber - i).gameObject);
                }
            }
            else
            {
                textNumberEntry.text = "0";
                UpdateTextItemsList();
            }
        }

        /// <summary>
        /// Reset textItem UI text, textPositionIndex and textButtonColor 
        /// </summary>
        public void ResetTextItemUI(Transform textItem)
        {
            textItem.gameObject.SetActive(true);

            textItem.GetChild(0).GetComponent<InputField>().text = "";
            textItem.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = "";
            textItem.GetChild(2).GetComponent<Image>().color = Color.white;
        }
    }
}