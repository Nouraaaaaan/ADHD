//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.IO;
//using Valve.VR.InteractionSystem.Sample;

//public class QuestionAnswer_System : System_Structure
//{   
//    public static void QuestionAnswer_manager(string URL , Vector3 point)
//    {
//        Obj = Load_AssetBundle(URL, point);
//    }

//    private static GameObject Load_AssetBundle(string URL, Vector3 point)
//    {
//        var myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "AssetBundles/" + URL));
//        if (myLoadedAssetBundle == null)
//        {
//            Debug.Log("Failed to load AssetBundle!");
//            return null;
//        }

//        //Get filename.
//        string filename = System.IO.Path.GetFileNameWithoutExtension(URL);
//        Debug.Log("filename :" + URL);

//        GameObject obj = myLoadedAssetBundle.LoadAsset<GameObject>(filename);
//        GameObject clone = Instantiate(obj, point, Quaternion.identity);

//        myLoadedAssetBundle.Unload(false);

//        return clone;
//    }

//    public static  IEnumerator LoadNextQuestion(Scene_Manager Scene_Manager)
//    {
//        yield return new WaitForSeconds(3f);

//       nextquestion = true;
//     CanClick = true;
//      IsAnswerTrue = false;

//        Obj.SetActive(false);
//        Scene_Manager.RightAnswer.SetActive(false);
//        Scene_Manager.WrongAnswer.SetActive(false);
//    }

//    public void CheckAnswer(Scene_Manager Scene_Manager)
//    {          
//        if (CanClick == true)
//        {
//            if (IsAnswerTrue)
//            {
//                Scene_Manager.WrongAnswer.SetActive(false);
//                Scene_Manager.RightAnswer.SetActive(true);
//            }
//            else
//            {
//                Scene_Manager.RightAnswer.SetActive(false);
//                Scene_Manager.WrongAnswer.SetActive(true);
//            }

//            StartCoroutine(LoadNextQuestion(Scene_Manager));
//        }

//    }
//}
