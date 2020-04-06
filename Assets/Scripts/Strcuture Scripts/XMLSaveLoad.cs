using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class XMLSaveLoad : MonoBehaviour
    {
        public bool save;
        public bool load;

        private void Update()
        {
            CheckSave();
            CheckLoad();
        }

        void CheckSave()
        {
            if (save)
            {
                Xml_Manager.ins.SaveItems();
                save = false;
                Debug.Log("save");
            }
        }

        void CheckLoad()
        {
            if (load)
            {
                Xml_Manager.ins.Loaditems();
                load = false;
                Debug.Log("load");
            }
        }
    }
}