//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ResetParent : MonoBehaviour
//{
//    private Transform InitialTransform;

//    private void Awake()
//    {
//        InitialTransform = gameObject.transform.parent;
//    }

//    private void OnCollisionStay(Collision collision)
//    {
//        if (collision.gameObject.tag == "studentdisk")
//        {
//            gameObject.transform.parent = InitialTransform;
//        }

//    }
//}
