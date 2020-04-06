using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    /// <summary>
    /// Manages 3D Models in the Element 
    /// </summary>
    public class Model3dSystem : Scene_Manager
    {
        public static bool model3DEnd;

        static MaterialPropertyBlock _propBlock;
        static List<GameObject> instantiatedObjectList = new List<GameObject>();

        static GameObject nearstModel;
        
        private void Start()
        {
            instantiated3DModels = System_Structure.Ins.instantiated3DModels;
        }

        public static IEnumerator Model3dManager(Element element)
        {
            print("3D Model Start");

            yield return new WaitForSeconds(element.model3DManager.delayTime);

            Vector3 position = CalculateInstantiationPosition(element);

            for (int i = 0; i < element.model3DManager.modelColor.Count; i++)
            {
                instantiatedObjectList.Add(Instantiate(System_Structure.Ins.Model3d[(int)element.model3DManager.model3d], position, Quaternion.identity));
                _propBlock = new MaterialPropertyBlock();

                // Get the current value of the material properties in the renderer.
                instantiatedObjectList[i].GetComponent<Renderer>().GetPropertyBlock(_propBlock);

                // Assign our new value, we just need one color 
                _propBlock.SetColor("_Color", element.model3DManager.modelColor[i].Color);
                instantiatedObjectList[i].GetComponent<Renderer>().SetPropertyBlock(_propBlock);

                position += element.model3DManager.distanceBetweenObjects;
            }

            if (element.model3DManager.catchObject)
            {
                yield return new WaitUntil(() => CharactersCatching.characterCatch == true);

                GetNearest3DModel(element.model3DManager.Runtime, element);
                Catch3DModel(element);
                instantiatedObjectList.Remove(nearstModel);
                Destroy(nearstModel, 8f);
                CharactersCatching.characterCatch = false;
            }
            
            model3DEnd = true;
            print("Mosel3D End");

        }

        /// <summary>
        /// Calculate the instantiating position (to be in the middle way between objects).
        /// </summary>
        /// <param name="element"></param>
        static Vector3 CalculateInstantiationPosition(Element element)
        {
            Vector3 allDistance = (element.model3DManager.modelColor.Count - 1) * element.model3DManager.distanceBetweenObjects;
            Vector3 halfDistance = allDistance / 2;
            Vector3 position = System_Structure.Ins.waypoints[(int)element.model3DManager.modelsPosition].transform.position - halfDistance;
            return position;
        }

        static GameObject GetNearest3DModel(bool runtime, Element element)
        {
            float distance, runtimenearestdistance, preruntimedistance;
            Vector3 characterPosition = System_Structure.Ins.Helper_characters[(int)element.characterManager.character].transform.position;

            switch (runtime)
            {
                case true:
                    nearstModel = instantiatedObjectList[0];
                    runtimenearestdistance = Vector3.Distance(characterPosition, nearstModel.transform.position);
                    for (int i = 0; i < instantiatedObjectList.Count; i++)
                    {
                        distance = Vector3.Distance(characterPosition, instantiatedObjectList[i].transform.position);
                        if (distance < runtimenearestdistance)
                        {
                            runtimenearestdistance = distance;
                            nearstModel = instantiatedObjectList[i];
                        }
                    }
                    break;

                case false:


                    nearstModel = System_Structure.Ins.classModel3d[(int)element.model3DManager.objectToCatch];

                    break;
            }
            return nearstModel;
        }

        static void Catch3DModel(Element element)
        {
            if (nearstModel != null)
            {
                nearstModel.transform.position = System_Structure.Ins.charactersHandPos[(int)element.characterManager.character].transform.position + new Vector3(0.2f, 0, 0);
                nearstModel.transform.parent = System_Structure.Ins.charactersHandPos[(int)element.characterManager.character].transform;
            }

        }

        public static void CheckModel3DReset(Element element)
        {
            if (element.model3DManager.reset)
            {
                Model3DReset();
            }
        }

        static void Model3DReset()
        {
            for (int i = 0; i < instantiatedObjectList.Count; i++)
            {
                Destroy(instantiatedObjectList[i]);
            }

            instantiatedObjectList.Clear();

            //Reset "characterCatch" to false in case there is many character catch in same element
            CharactersCatching.characterCatch = false;
        }
    }
}