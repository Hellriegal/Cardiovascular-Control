using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardButton : MonoBehaviour
{
    [SerializeField]
    string thisKey;
    [SerializeField]
    string altString;
    public bool pressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     checkPress();   
    }

    void checkPress()
    {
        if (Input.GetKey(thisKey))
        {
            pressed = true;
        }
        else if (altString != null & Input.GetKey(altString))
        {
            pressed = true;
        }
        else
        {
            pressed = false;
        }
    }
}
