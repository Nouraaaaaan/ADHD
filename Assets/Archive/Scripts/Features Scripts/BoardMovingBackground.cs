//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//namespace Valve.VR.InteractionSystem.Sample
//{
//    public class BoardMovingBackground : MonoBehaviour
//    {
        //public float scrollX;
        //public float scrollY;

        //bool show = false;
        //bool boolBackground = false;

        //#region Editing Area 
        //[Header("Scene Manager  Field")]
        //public Scene_Manager Scene_manager_obj;
        //#endregion

        //private void OnEnable()
        //{
        //    StartCoroutine(setshow());
        //}

        //IEnumerator setshow()
        //{
        //    yield return new WaitForSeconds(0.05f);
        //    show = true;
        //}

        //private void OnDisable()
        //{
        //    show = false;
        //}

        //void Update()
        //{
        //    DO_Animation();
        //}

        //public void DO_Animation()
        //{
        //    //   print("Animation Happening ");
        //    float offsetX = Time.time * scrollX;
        //    float offsetY = Time.time * scrollY;

        //    if (Xml_Manager.ins.theproject.thelesson[LessonsSelection.Lesson_index].THELEMENT[Scene_Manager.Transition_index].animationBoard.exist)
        //    {
        //        boolBackground = true;
        //        if (boolBackground)
        //        {
        //            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
        //        }
        //    }
        //}

        //public void AnimationDone()
        //{
        //    if (!show)
        //        return;

        //    gameObject.SetActive(false);
        //}


//    }
//}