using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class FileExplorer : MonoBehaviour
{
   public static string path;       // Stores file path of selected image

   public void OpenFileExp()
   {
       path = EditorUtility.OpenFilePanel("Overwrite with jpeg", "", "jpeg,png,jpg");

       if(path != null)
       {
           LoadNextLevel();
       }
   }

   public void LoadNextLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
