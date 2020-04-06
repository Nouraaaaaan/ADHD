using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    public class ElementPanel : MonoBehaviour
    {
        public Dropdown elementsDropdown;
        public List<Button> elementPartsButtons;
        public List<GameObject> elementPartsPanels;

        void Start()
        {
            Xml_Manager.ins.Loaditems();

            LoadElementsDropdownOptions();

            elementsDropdown.onValueChanged.AddListener(delegate
            {
                DropdownValueChanged(elementsDropdown);
            });

            UpdateAllElementPartsData();

            for (int i = 0; i < elementPartsButtons.Count; i++)
            {
                int elementPartIndex = i;
                elementPartsButtons[elementPartIndex].onClick.AddListener(() => ShowChoosenPanel(elementPartIndex));
            }

        }

        void ShowChoosenPanel(int elementPartIndex)
        {
            Debug.Log(elementPartIndex);

            for (int i = 0; i < elementPartsButtons.Count; i++)
            {
                if (i == elementPartIndex)
                {
                    elementPartsPanels[i].SetActive(true);
                    Debug.Log(i);
                }
                else
                    elementPartsPanels[i].SetActive(false);
            }
        }

        void LoadElementsDropdownOptions()
        {
            if (Xml_Manager.ins != null)
            {
                List<string> dropdownData = new List<string>();
                for (int i = 0; i < Xml_Manager.ins.subject.lessons[0].elements.Count; i++)
                {
                    dropdownData.Add((i).ToString());
                }
                elementsDropdown.AddOptions(dropdownData);
            }
        }

        //here , we should refresh all values of the element and the UI parts we preview (Later)
        void DropdownValueChanged(Dropdown change)
        {
            //need one for lesson to set lessonindex
            System_Structure.elementIndex = change.value;
            UpdateAllElementPartsData();
        }

        void UpdateAllElementPartsData()
        {
            Element element = Xml_Manager.ins.subject.lessons[System_Structure.lessonIndex].elements[System_Structure.elementIndex];
            //because game object that have TextPanel script is deactivated , so we need to add another gameobject theat hold the script or add a way to update the part that have choosen click or whatever (Later)

            if (TextPanel.Instance != null)
            TextPanel.Instance.LoadText(element);

            if (AudioPanel.Instance != null)
                AudioPanel.Instance.LoadAudio(element);
        }

        public void CreateNewElement()
        {
            Element element = new Element();
            Xml_Manager.ins.subject.lessons[0].elements.Add(element);
            //need edit , index static
            AddNewOptionToDropdown(Xml_Manager.ins.subject.lessons[0]);

            Xml_Manager.ins.SaveItems();
        }

        void AddNewOptionToDropdown(Lesson lesson)
        {
            List<string> dropdownData = new List<string>();
            int optionNumber = lesson.elements.Count - 1;
            dropdownData.Add(optionNumber.ToString());
            elementsDropdown.AddOptions(dropdownData);
        }
    }
}