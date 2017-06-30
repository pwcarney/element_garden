using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Element : MonoBehaviour
{
    public GameObject button;

    Image button_image;
    Camera cam;

    bool isHeld = false;

    protected void Start()
    {
        button_image = button.GetComponent<Image>();

        cam = Camera.main;
    }

    protected void FixedUpdate()
    {
        // Change button color
        if (isHeld)
            button_image.color = Color.red;
        else
            button_image.color = Color.white;

        // Execute element functionality
        if (Input.GetMouseButton(0) && isHeld)
        {
            // Create a ray cast and set it to the mouses cursor position in game
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 50f))
            {
                //draw invisible ray cast/vector
                Debug.DrawLine(ray.origin, hit.point);
                Execute(hit.point);
            }
        }
    }

    // Needs to be implemented in the specific element classes
    protected abstract void Execute(Vector3 inputVec);

    public void Holding ()
    {
        isHeld = true;
    }

    public void NotHolding()
    {
        isHeld = false;
    }
}
