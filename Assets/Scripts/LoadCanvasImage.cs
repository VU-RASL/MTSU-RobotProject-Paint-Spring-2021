using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class LoadCanvasImage : MonoBehaviour
{
    public RawImage paletteImage;
    
    // Start is called before the first frame update
    void Start()
    {
        if(FileExplorer.path != null)
        {
            WWW www = new WWW("file:///" + FileExplorer.path);
            paletteImage.texture = www.texture;
        }
    }

}
