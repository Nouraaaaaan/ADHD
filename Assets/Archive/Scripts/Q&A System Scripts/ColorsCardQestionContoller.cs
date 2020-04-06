//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Valve.VR.InteractionSystem.Sample;

//public class ColorsCardQestionContoller : MonoBehaviour
//{
//    public static int RedCnt, YellowCnt, TotalRedCnt, TotalYellowCnt;

//    // Start is called before the first frame update
//    void Start()
//    {
//        RedCnt = 0;
//        YellowCnt = 0;
//        TotalRedCnt = 0;
//        TotalYellowCnt = 0;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if ((RedCnt.ToString() == Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].questionManager.Answers[0]) && (YellowCnt.ToString() == Xml_Manager.ins.subject.lessons[0].elements[Scene_Manager.Transition_index].questionManager.Answers[1]) && (TotalRedCnt.ToString() == Xml_Manager.ins.subject.lessons[0].elements[Scene_Manager.Transition_index].questionManager.Answers[0]) && (TotalYellowCnt.ToString() == Xml_Manager.ins.subject.lessons[0].elements[Scene_Manager.Transition_index].questionManager.Answers[1]))
//        {
//            Scene_Manager.IsAnswerTrue = true;
//            Debug.Log("Right Answer");
//        }

//    }
//}
