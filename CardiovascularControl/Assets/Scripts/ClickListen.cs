﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickListen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        listen();
    }

    void listen()
    {
        if (Input.GetMouseButton(0)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) 
            {
                hit.collider.gameObject.SendMessage("mouseClick");
            }
        }
    }
}
