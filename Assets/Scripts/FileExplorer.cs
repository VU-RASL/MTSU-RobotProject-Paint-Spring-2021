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

//    Nibraas Code
//    public void ConnectToRobot() {

//         string path_ip = Application.dataPath + @"/RobotCode/Nao_Config.txt";
//         lineChanger(ip_address.text, path_ip, 2);

//         string path = Application.dataPath + @"/RobotCode/testSocketAndRobot.py";
//         path = """ + path + """;
//         string strCmdText = "/K cd "Assets/RobotCode" && python " + path;

//         ProcessStartInfo startInfo = new ProcessStartInfo();
//         startInfo.FileName = "CMD.exe";
//         startInfo.Arguments = strCmdText;
//         startInfo.WindowStyle = ProcessWindowStyle.Hidden;
//         Process.Start(startInfo);
//     }
}
