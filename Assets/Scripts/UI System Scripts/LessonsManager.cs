using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.InteractionSystem.Sample
{
    public class LessonsManager : MonoBehaviour
    {
        public Dropdown lessonsDropdown;
  
        public void CreateNewLesson()
        {
            Lesson lesson = new Lesson();
            Xml_Manager.ins.subject.lessons.Add(lesson);
            AddNewOptionToDropdown(Xml_Manager.ins.subject);
        }

        void AddNewOptionToDropdown(Subject subject)
        {
            List<string> dropdownData = new List<string>();
            dropdownData.Add(subject.lessons.Count.ToString());
            lessonsDropdown.AddOptions(dropdownData);
        }

    }
}