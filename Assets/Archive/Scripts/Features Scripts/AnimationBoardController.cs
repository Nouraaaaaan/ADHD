//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//namespace Valve.VR.InteractionSystem.Sample
//{
    /// <summary>
    /// Temp. script.
    /// </summary>
    //public class AnimationBoardController : MonoBehaviour
    //{
        //public GameObject BoardMovingBackground;

        //bool boolBackground = false;

        //Animator animator;

        //#region Editing Area 
        //[Header("Scene Manager  Field")]
        //public Scene_Manager Scene_manager_obj;
        //#endregion

        //#region Customize Board Field 
        //[Header("Customize Board Field ")]
        //public float scrollX;
        //public float scrollY;

        //public BoardMovingBackground board_obj;
        //#endregion

        //void Start()
        //{
        //    animator = BoardMovingBackground.GetComponent<Animator>();
        //}

        //private void Update()
        //{
        //    Check_Board_style();
        //}

        //private void Check_Board_style()
        //{
        //    if (Xml_Manager.ins.theproject.thelesson[LessonsSelection.Lesson_index].THELEMENT[Scene_Manager.Transition_index].animationBoard.exist)
        //    {
        //        boolBackground = true;

        //        if (boolBackground)
        //        {
        //            BoardMovingBackground.GetComponent<Renderer>().material = Scene_manager_obj.boardMaterials[(int)Xml_Manager.ins.theproject.thelesson[LessonsSelection.Lesson_index].THELEMENT[Scene_Manager.Transition_index].animationBoard.style];
        //            board_obj.DO_Animation();
        //            BoardMovingBackground.active = true;
        //        }

        //    }
        //    else
        //    {
        //        animator.SetBool("Appear", false);
        //    }
        //}

        //void DeactivateBoardMovingBackground()
        //{
        //    BoardMovingBackground.active = false;
        //}
//    }

//}