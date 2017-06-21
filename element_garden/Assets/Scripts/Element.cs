using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour
{
    public GameObject button;

    protected bool isHeld = false;

    Image button_image;

    void Start()
    {
        button_image = button.GetComponent<Image>();
    }

    void Update()
    {
        if (isHeld)
        {
            button_image.color = Color.red;
        }
        else
        {
            button_image.color = Color.white;
        }
    }

    public void Holding ()
    {
        isHeld = true;
    }

    public void NotHolding()
    {
        isHeld = false;
    }
}
