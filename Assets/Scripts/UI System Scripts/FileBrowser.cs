using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class FileBrowser : MonoBehaviour
    {
        /// <summary>
        /// Get the full path from file browse
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string GetFullPath(string[] paths)
        {
            string path = "";

            if (paths.Length == 0)
            {
                return "";
            }

            foreach (var p in paths)
            {
                path += p;
            }

            return path.Replace("\\", "/");
        }

        /// <summary>
        /// Extract the file small part "ex: Audio/whatever" from a full path
        /// </summary>
        public static string GetFileSmallPath(string filePath, string fullPath)
        {
            string fileSmallName;

            if (fullPath.Contains(filePath))
            {
                fileSmallName = fullPath.Replace(filePath + "/", "");

                string temp = "";
                for (int i = 0; i < fileSmallName.Length; i++)
                {
                    if (fileSmallName[i] == '.')
                        break;

                    temp += fileSmallName[i];
                }
                return temp;
            }
            return "";
        }
    }
}