using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class CharactersCatching : MonoBehaviour
    {
        public static bool characterCatch;

        public void Catch3DObject()
        {
            characterCatch = true;
            Debug.Log("_____ character catch _____");
        }
    }

}
