using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

        if(path != null && path != "")
        {
           LoadNextLevel();
        }
    }


    public void ConvertImage()
    {
        string path1 = Application.dataPath + @"/Scripts/countours.py";
        path1 = "\"" + path1 + "\"";
        string strCmdText = "/K cd \"Assets / Scripts\" && python " + path1;
        
        path = EditorUtility.OpenFilePanel("Overwrite with jpeg", "", "jpeg,png,jpg");

        if(path != null && path != "")
        {
           LoadNextLevel();
        }

        // Nibraas Code
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "CMD.exe";
        startInfo.Arguments = strCmdText;
        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
        Process.Start(startInfo);
    }

    // Scene Transition
    public void LoadNextLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
