using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class QuitMainMenu : MonoBehaviour
{
    public void HomeScreen()
    {
        SceneManager.LoadScene(0);
    }
}
