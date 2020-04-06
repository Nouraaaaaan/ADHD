using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    public class TextPanel : MonoBehaviour
    {
        public static int textItemIndex;

        public TextItemPanel textItemPanel;
        public InputField textNumberEntry;
        public Transform textItemsGrid;
        public Transform textPositionImage;
        public ColorPickerUnityUI colorPickerUnityUI;
        public InputField delayTime;
        public Toggle reset;

        int buttonPositionIndex;

        public static TextPanel Instance
        {
            get;
            private set;
        }

        private void Start()
        {
            // Singlton
            Instance = this;
        }

        #region Manage Text Color UI 

        private void Update()
        {
            CheckColorChange();
        }

        /// <summary>
        /// If colorPicker value changed, change button color 
        /// </summary>
        void CheckColorChange()
        {
            GameObject colorPicker = colorPickerUnityUI.transform.parent.gameObject;

            if (colorPickerUnityUI.click)
            {
                ColorTextColorButton();
                colorPickerUnityUI.click = false;
            }
            else if (colorPickerUnityUI.WasClicked)
            {
                colorPicker.SetActive(false);
                colorPickerUnityUI.WasClicked = false;
            }
        }

        /// <summary>
        /// Coloring the textColor button by choosen value.
        /// </summary>
        void ColorTextColorButton()
        {
            textItemsGrid.GetChild(textItemIndex).GetChild(2).GetComponent<Image>().color = colorPickerUnityUI.value;
        }

        #endregion

        #region Manage Text Position UI 

        /// <summary>
        /// This function called by textPosition button from the scene to update the choosen toggle from textPositionImage
        /// </summary>
        /// <param name="child"></param>
        public void UpdateTextPositionImage()
        {
            string textPosition = textItemsGrid.GetChild(textItemIndex).transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text;

            ResetAllToggles();

            if (textPosition != "")
            {
                int x = int.Parse(textPosition);
                textPositionImage.GetChild(x + 1).GetComponent<Toggle>().isOn = true;
            }
        }

        void ResetAllToggles()
        {
            for (int i = 1; i < textPositionImage.childCount - 1; i++)
            {
                textPositionImage.GetChild(i).GetComponent<Toggle>().isOn = false;
            }
        }

        /// <summary>
        /// This function called by textPosition toggles from the scene to get the choosen position "Index".
        /// </summary>
        /// <param name="textPos"></param>
        public void GetTextPosition(int textPos)
        {
            buttonPositionIndex = textPos;
            SetTextPositionUIValue();
        }

        void SetTextPositionUIValue()
        {
            textItemsGrid.GetChild(textItemIndex).transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = buttonPositionIndex.ToString();
        }

        #endregion

        #region Save Text 

        /// <summary>
        /// Save the text part values to the xml file.
        /// TextPart: exist, textItem(text, textPosition, textColor), delayTime, reset
        /// </summary>
        public void SaveText()
        {
            Element element = Xml_Manager.ins.subject.lessons[System_Structure.lessonIndex].elements[System_Structure.elementIndex];

            if (TextItemPanel.textNumber > 0)
            {
                element.textManager.exist = true;

                SaveTextItems(element);
                element.textManager.delayTime = (delayTime.text == "") ? 0 : float.Parse(delayTime.text);
                element.textManager.reset = reset.isOn;
            }
            else
                element.textManager.exist = false;

            Xml_Manager.ins.SaveItems();
        }

        /// <summary>
        /// Save all textItems at the element
        /// </summary>
        void SaveTextItems(Element element)
        {
            ModifyTextItemsListSize(element);

            for (int i = 0; i < TextItemPanel.textNumber; i++)
            {
                Transform textItem = textItemsGrid.GetChild(i + 1).transform;

                element.textManager.textItems[i].text = textItem.GetChild(0).GetComponent<InputField>().text;

                string text = textItem.GetChild(1).transform.GetChild(1).GetComponent<Text>().text;
                element.textManager.textItems[i].position = (int.TryParse(text, out int textPos)) ? (TextPosition)(textPos) : (TextPosition)(0);

                element.textManager.textItems[i].color = textItem.GetChild(2).GetComponent<Image>().color;
            }
        }

        /// <summary>
        /// Resize textItems list based on textNumber UI.
        /// </summary>
        void ModifyTextItemsListSize(Element element)
        {
            int listCount = element.textManager.textItems.Count;

            if (TextItemPanel.textNumber < listCount)
            {
                element.textManager.textItems.RemoveRange(TextItemPanel.textNumber - 1, listCount - TextItemPanel.textNumber);
            }
            else if (TextItemPanel.textNumber > listCount)
            {
                for (int i = 0; i < TextItemPanel.textNumber; i++)
                {
                    // If there is no instance for textItem, create one
                    if (i >= listCount)
                        element.textManager.textItems.Add(new TextItem());
                }
            }
        }

        #endregion

        #region Load Text 

        /// <summary>
        /// Load the text part values from the xml file.
        /// TextPart: exist, textItem(text, textPosition, textColor), delayTime, reset
        /// </summary>
        public void LoadText(Element element)
        {
            if (element.textManager.exist)
            {
                textNumberEntry.text = element.textManager.textItems.Count.ToString();
                textItemPanel.UpdateTextItemsList();

                for (int i = 0; i < element.textManager.textItems.Count; i++)
                {
                    Transform textItem = textItemsGrid.GetChild(i + 1).transform;

                    textItem.GetChild(0).GetComponent<InputField>().text = element.textManager.textItems[i].text;
                    textItem.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = ((int)element.textManager.textItems[i].position).ToString();
                    textItem.GetChild(2).GetComponent<Image>().color = element.textManager.textItems[i].color;
                }

                delayTime.text = element.textManager.delayTime.ToString();
                reset.isOn = element.textManager.reset;
            }
            else
            {
                textNumberEntry.text = "0";
                textItemPanel.UpdateTextItemsList();

                //Reset
                delayTime.text = "";
                reset.isOn = false;
            }

        }

        #endregion

        /// <summary>
        /// This function called by textColor button and textPosition Button from the scene to get the textItem index for clicked button
        /// </summary>
        /// <param name="child"></param>
        public void GetTextItemIndex(Transform child)
        {
            textItemIndex = child.GetSiblingIndex();
        }

    }
}