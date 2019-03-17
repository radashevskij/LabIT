using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void onGUI()
    {
        GUI.Box(new Rect(Screen.width - 100, 50, 100, 100), "Health: ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
