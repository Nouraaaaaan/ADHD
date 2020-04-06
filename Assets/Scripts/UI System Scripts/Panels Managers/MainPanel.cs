using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    public class MainPanel : MonoBehaviour
    {
        public Dropdown lessonsDropdown;
        public Dropdown subjectsDropdown;
        public Dropdown semstersDropdown;
        public Dropdown academicYearsDropdown;

        private void Start()
        {
            Xml_Manager.ins.Loaditems();

            LoadLessonsToDropdown();
        }

        void LoadLessonsToDropdown()
        {
            if (Xml_Manager.ins != null)
            {
                List<string> dropdownData = new List<string>();

                int lessonsNumber = Xml_Manager.ins.subject.lessons.Count;
                for (int i = 0; i < lessonsNumber; i++)
                {
                    dropdownData.Add((i).ToString());
                }
                lessonsDropdown.AddOptions(dropdownData);
            }
        }

    }
}