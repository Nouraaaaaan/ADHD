//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using System;
//using System.Text;
//using Valve.VR.InteractionSystem.Sample;

//public class ChangeCharColor : MonoBehaviour
//{
    //Text txt;

    //private void Start()
    //{
    //    txt = gameObject.GetComponent<Text>();
    //    ChangeCharClr();
    //}

    //public void ChangeCharClr()
    //{
    //    int size = Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].textManager.textColors.Count;

    //    for (int i = size - 1; i >= 0; i--)
    //    {
    //        string CharColor = ColorUtility.ToHtmlStringRGB(Xml_Manager.ins.subject.lessons[LessonsSelection.Lesson_index].elements[Scene_Manager.Transition_index].textManager.textColors[i]);

    //        StringBuilder StringBuilder = new StringBuilder(txt.text, 50);
    //        StringBuilder.Insert(i + 1, "</color>");
    //        StringBuilder.Insert(i, "<color=#" + CharColor + ">");

    //        txt.text = StringBuilder.ToString();
    //        Debug.Log("change");
    //    }
    //}
//}

///Change Char Color From Scene Manager 
/*
 
      #region Text Color Area

        IEnumerator ChangeCharColor()
        {
            yield return new WaitForSeconds(0.01f);

            //xml_txt_position_index is removed from system structure script
            Display_txts[xml_txt_position_index].GetComponent<ChangeCharColor>().enabled = true;
        }

        #endregion

*/
