//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Valve.VR.InteractionSystem.Sample;

//public class ChoicesQuestionController : MonoBehaviour
//{

//    public GameObject Buttons;

//    public void Start()
//    {
//        int size = Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.buttonName.Length;  // get the length ( number of buttons )

//        for (int i = 0; i < size; i++)
//        {
//            Buttons.transform.GetChild(i).gameObject.transform.GetChild(0).GetComponent<ArabicText>().Text
//                  =
//      Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.buttonName[i];  // pass the numbers to text for every button 
//        }

//    }

//    public void CheckAnswer(string s)
//    {
//        Debug.Log("Answer is : " + Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.Answers[0]);

//        if (Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.Answers[0].Equals(s))
//        {
//            Scene_Manager.IsAnswerTrue = true;
//        }
//        else
//        {
//            Scene_Manager.IsAnswerTrue = false;
//        }
//    }

//    public void OnClick_BtnOne()
//    {
//        CheckAnswer("1");

//    }

//    public void OnClick_BtnTwo()
//    {
//        CheckAnswer("2");
//    }

//    public void OnClick_BtnThree()
//    {
//        CheckAnswer("3");
//    }

//    public void OnClick_BtnFour()
//    {
//        CheckAnswer("4");
//    }

//    public void OnClick_BtnFive()
//    {
//        CheckAnswer("5");
//    }

//    public void OnClick_BtnSix()
//    {
//        CheckAnswer("6");
//    }

//    public void OnClick_BtnSeven()
//    {
//        CheckAnswer("7");
//    }

//    public void OnClick_BtnEight()
//    {
//        CheckAnswer("8");
//    }

//    public void OnClick_BtnNine()
//    {
//        CheckAnswer("9");
//    }

//    public void OnClick_BtnTen()
//    {
//        CheckAnswer("10");
//    }

//}
