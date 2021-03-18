using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorColor : MonoBehaviour
{
    public Color cursorColor;
    public SpriteRenderer cursor;

    // Assigns button color to cursor color
    public void ChangeColor()
    {
        cursorColor = GetComponent<Image>().color;
        cursor.color = cursorColor;
    }

}
