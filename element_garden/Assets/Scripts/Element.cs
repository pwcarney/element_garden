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
    Vector3 cam_pos;
    Vector3 screen_center_pos;
    float screen_to_camera_dist;

    bool isHeld = false;

    void Start()
    {
        button_image = button.GetComponent<Image>();

        cam = Camera.main;

        cam_pos = cam.transform.position;

        screen_center_pos = cam.ScreenToWorldPoint(
            new Vector3(
                Screen.width / 2f,
                Screen.height / 2f,
                cam.nearClipPlane));

        screen_to_camera_dist = Vector3.Distance(cam_pos, screen_center_pos);
    }

    void Update()
    {
        // Change button color
        if (isHeld)
            button_image.color = Color.red;
        else
            button_image.color = Color.white;

        // Execute functionality
        if (Input.GetMouseButton(0) && isHeld)
        {
            Execute( GetMouseFieldPosition() );
        }
    }

    // Needs to be implemented in the specific element classes
    protected abstract void Execute(Vector3 inputVec);

    public Vector3 GetMouseFieldPosition()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(
            new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                cam.nearClipPlane));

        float x_dist = mousePos.x - screen_center_pos.x;
        float y_dist = mousePos.y - screen_center_pos.y;

        float x_angle = (float)Math.Atan2(x_dist, screen_to_camera_dist);
        float y_angle = (float)Math.Atan2(y_dist, screen_to_camera_dist);

        float x = (float)Math.Tan(Math.PI - (cam.transform.eulerAngles.y * Math.PI / 180f) + x_angle) * mousePos.x + mousePos.x;
        float z = (float)Math.Tan(Math.PI - (cam.transform.eulerAngles.x * Math.PI / 180f) + y_angle) * mousePos.z + mousePos.z;
        float y = 0.5f;

        Debug.Log(new Vector3(x, y, z));
        return new Vector3(x, y, z);
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
