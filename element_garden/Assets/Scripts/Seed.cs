using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour {

    int water_level = 0;

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Raindrop")
        {
            Debug.Log(water_level++);
        }
    }
}
