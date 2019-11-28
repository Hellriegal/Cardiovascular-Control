using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageSwitch : MonoBehaviour
{
    public Sprite idle;
    public Sprite pressed;

    public KeyboardButton keyboardButton;
    public Button button;
    SpriteRenderer spriteRenderer;
    [SerializeField]
    int scriptCheck;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        keyboardButton = GetComponent<KeyboardButton>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        checkScriptsNull();
    }

    // Update is called once per frame
    void Update()
    {
      checkScriptsNull();
      switcher();
    }

    void checkScriptsNull()
    {
        if (keyboardButton != null & button == null)
        {
            scriptCheck = 1;
        }
        else if (keyboardButton == null & button != null)
        {
            scriptCheck = 2;
        }
        else if (keyboardButton != null & button != null)
        {
            scriptCheck = 3;
        }
    }

    void switcher()
    {
        switch(scriptCheck)
        {
            case 1:
            if (keyboardButton.pressed == true)
            {
                spriteRenderer.sprite = pressed;
            }
            else
            {
                spriteRenderer.sprite = idle;
            }
                break;

            case 2:
            if (button.pressed == true)
            {
                spriteRenderer.sprite = pressed;
            }
            else
            {
                spriteRenderer.sprite = idle;
            }
                break;
            case 3:
            if (button.pressed == true || keyboardButton.pressed == true)
            {
                spriteRenderer.sprite = pressed;
            }
            else
            {
                spriteRenderer.sprite = idle;
            }
                break;
        }
    }
}
