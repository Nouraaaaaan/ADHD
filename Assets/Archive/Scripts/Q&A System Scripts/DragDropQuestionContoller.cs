//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using System;
//using Valve.VR.InteractionSystem.Sample;

//public class DragDropQuestionContoller : MonoBehaviour
//{

//    public GameObject Addition, Subtraction, Multiplication, Division;
//    public static int cnt;
//    public static bool won;

//    public GameObject[] Triggers;

//    void Start()
//    {
//        cnt = 0;
//        won = false;

//        switch (Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.Operationtype.ToString())
//        {
//            case "Addition":
//                Addition.SetActive(true);
//                break;

//            case "Subtraction":
//                Subtraction.SetActive(true);
//                break;

//            case "Multiplication":
//                Multiplication.SetActive(true);
//                break;

//            case "Division":
//                Division.SetActive(true);
//                break;

//        }


//        for (int i = 0; i < Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.Answers.Count; i++)
//        {
//            //Debug.Log("tag : "+Xml_Manager.ins.itemDB.Dialouge_items[Scene_Manager.Transition_index].manage_question.Answers[i]);
//            Triggers[i].transform.gameObject.tag = Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.Answers[i];
//        }

//    }

//    void Update()
//    {
//        if (cnt == Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.Answers.Count)
//        {
//            Debug.Log("Answer is true");
//            won = true;
//            Scene_Manager.IsAnswerTrue = true;
//        }

//    }

//}
