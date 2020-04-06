//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ColorsCardTrigger : MonoBehaviour
//{
//    private void OnTriggerEnter(Collider other)
//    {
//        if((gameObject.tag == "red")&&(other.gameObject.tag == "red"))
//        {
//            Debug.Log("increment RedCnt");
//            ColorsCardQestionContoller.RedCnt++;
//        }

//        if((gameObject.tag == "yellow") && (other.gameObject.tag == "yellow"))
//        {
//            Debug.Log("increment yellowCnt");
//            ColorsCardQestionContoller.YellowCnt++;
//        }

//        if ((gameObject.tag == "total") && (other.gameObject.tag == "red"))
//        {
//            Debug.Log("increment TotalRedCnt");
//            ColorsCardQestionContoller.TotalRedCnt++;
//        }

//        if ((gameObject.tag == "total") && (other.gameObject.tag == "yellow"))
//        {
//            Debug.Log("increment TotalYellowCnt");
//            ColorsCardQestionContoller.TotalYellowCnt++;
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        if ((gameObject.tag == "red") && (other.gameObject.tag == "red"))
//        {
//            ColorsCardQestionContoller.RedCnt--;
//        }

//        if ((gameObject.tag == "yellow") && (other.gameObject.tag == "yellow"))
//        {
//            ColorsCardQestionContoller.YellowCnt--;
//        }

//        if ((gameObject.tag == "total") && (other.gameObject.tag == "red"))
//        {
//            ColorsCardQestionContoller.TotalRedCnt++;
//        }

//        if ((gameObject.tag == "total") && (other.gameObject.tag == "yellow"))
//        {
//            ColorsCardQestionContoller.TotalYellowCnt++;
//        }

//    }

//}
