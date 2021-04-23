using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class MouseCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;    // Hides system cursor and only shows custom cursor
    }

    // Update is called once per frame
    void Update()
    {
        // Set custom cursor to follow system cursor movement and position
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos; 
    }
}
