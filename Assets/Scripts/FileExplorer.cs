using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class FileExplorer : MonoBehaviour
{
   public string path;       // Stores file path of selected image
   public RawImage image;    // For displaying selected image on game menu screen

   public void OpenFileExp()
   {
       path = EditorUtility.OpenFilePanel("Overwrite with jpeg", "", "jpeg,png,jpg");
       GetImage();
   }

   void GetImage()
   {
       if (path != null)
       {
           UpdateImage();
       }
   }

   void UpdateImage()
   {
       WWW www = new WWW("file:///" + path);
       image.texture = www.texture;
   }
}
