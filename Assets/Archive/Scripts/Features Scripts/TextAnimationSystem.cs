//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TextAnimationSystem : MonoBehaviour
//{
    #region Text Animation Methods

    //void ExecuteChoosenAnimation(Transform startingPoint, Vector3 endingPoint)
    //{
    //    TextAnimationManager textAnimationManager = new TextAnimationManager();

    //    switch (The_Element[Transition_index].manage_text.textAnimationManager.textAnimation)
    //    {
    //        case TextAnimation.move:
    //            StartCoroutine(textAnimationManager.Move(startingPoint, endingPoint));
    //            break;
    //        case TextAnimation.scaleUp:
    //            StartCoroutine(textAnimationManager.ScaleUp(Display_txts[(int)The_Element[Transition_index].manage_text.Position_index].transform));
    //            break;
    //        case TextAnimation.scaleDown:
    //            StartCoroutine(textAnimationManager.ScaleDown(Display_txts[(int)The_Element[Transition_index].manage_text.Position_index].transform));
    //            break;
    //        case TextAnimation.rotate:
    //            StartCoroutine(textAnimationManager.Rotate(Display_txts[(int)Xml_Manager.ins.itemDB.Dialouge_items[Transition_index].manage_text.Position_index].transform));
    //            break;
    //        default:
    //            break;
    //    }
    //}

    #endregion


    #region Text Animation Implementation Area		

    //xml_txt_position_index is removed from system structure script


    //if (DIALOUGE[Transition_index].manage_text.Position_index == DIALOUGE[Transition_index].manage_text.textAnimationManager.startingPoint)
    //{
    //    DIALOUGE[Transition_index].manage_text.textAnimationManager.animationExist = false;
    //}

    //if (DIALOUGE[Transition_index].manage_text.textAnimationManager.animationExist)
    //{
    //    int startingTextIndex = (int)DIALOUGE[Transition_index].manage_text.textAnimationManager.startingPoint; // pass the position of Text index to Temp_variable 
    //    int targetTextIndex = (int)DIALOUGE[Transition_index].manage_text.Position_index; // pass the position of Text index to Temp_variable 
    //    Vector3 endingpointOurLocationMain = Display_txts[targetTextIndex].transform.position;

    //    //this line need to be for move onlyy
    //    if ((int)DIALOUGE[Transition_index].manage_text.textAnimationManager.textAnimation == 0)
    //    {
    //        Display_txts[targetTextIndex].transform.position = Display_txts[startingTextIndex].transform.position;
    //    }

    //    Display_txts[targetTextIndex].GetComponent<ArabicText>().Text = DIALOUGE[Transition_index].manage_text.Text_Dialouge; // pass the xml text in the position of list of texts 

    //    StartCoroutine(ChangeCharColor());
    //    ExecuteChoosenAnimation(Display_txts[targetTextIndex].transform, endingpointOurLocationMain);

    //    xml_txt_position_index = (int)DIALOUGE[Transition_index].manage_text.Position_index; // pass the position of Text index to Temp_variable 
    //    Display_txts[xml_txt_position_index].GetComponent<ArabicText>().Text = DIALOUGE[Transition_index].manage_text.Text_Dialouge; // pass the xml text in the position of list of texts 

    //}
    //else
    //{
    //    xml_txt_position_index = (int)DIALOUGE[Transition_index].manage_text.Position_index; // pass the position of Text index to Temp_variable 
    //    Display_txts[xml_txt_position_index].GetComponent<ArabicText>().Text = DIALOUGE[Transition_index].manage_text.Text_Dialouge; // pass the xml text in the position of list of texts 
    //   // StartCoroutine(ChangeCharColor());
    //}

    #endregion

//}
