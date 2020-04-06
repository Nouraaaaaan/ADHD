using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
namespace Valve.VR.InteractionSystem.Sample
{
    public class TrackerKEys : MonoBehaviour
    {
        
        public SteamVR_Action_Boolean plantAction;
        public SteamVR_Action_Boolean CAtchPhone;


        public Hand hand;
        public int x,nextscreen;
      public bool newValue2;
  
  
        // Start is called before the first frame update
        private void OnEnable()
        {
            if (hand == null)
                hand = this.GetComponent<Hand>();

            if (plantAction == null)
            {
                Debug.LogError("<b>[SteamVR Interaction]</b> No plant action assigned");
                return;
            }
            if (CAtchPhone == null)
            {
                Debug.LogError("<b>[SteamVR Interaction]</b> No plant action assigned");
                return;
            }
            CAtchPhone.AddOnChangeListener(CatchPhone, hand.handType);
            plantAction.AddOnChangeListener(OnPlantActionChange, hand.handType);
        }

        private void OnDisable()
        {
            if (plantAction != null)
                plantAction.RemoveOnChangeListener(OnPlantActionChange, hand.handType);
        }
        private void CatchPhone(SteamVR_Action_Boolean actionIn, SteamVR_Input_Sources inputSource, bool newValue)
        {
            print("DONE 0 ");
            Debug.LogError("hello");
            newValue2 = newValue;
            if (newValue)
            {
                nextscreen = 1;
                nextscreen = 1;
            }
            else
            {
             
            }

        }
        public static bool Keypressed; 
        public   void OnPlantActionChange(SteamVR_Action_Boolean actionIn, SteamVR_Input_Sources inputSource, bool newValue1)
        {
            print("DONE 1 ");
            Keypressed = true; 
            //if (newValue1==true&newValue2 == true)
            //{

            // // GameManger.Emptyobj = GameManger.Emptyobj + 1;           
            //}
        
        }
    }
}