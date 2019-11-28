using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    SpriteRenderer thisRenderer;
    public bool pressed = false;
    public ClickListen clickListen;
    // Start is called before the first frame update
    void Start()
    {
        thisRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        pressedFalse();
    }

    void pressedFalse()
    {
        if (!Input.GetMouseButton(0)) 
        {
            pressed = false;
        }
    }

    public void mouseClick()
    {
        pressed = true;
    }
}
