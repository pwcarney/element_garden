using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour {

    int water_level = 0;
    int sun_level = 0;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Raindrop")
        {
            water_level++;
            Destroy(other.gameObject);
        }
        else if (other.tag == "Sunbeam")
        {
            sun_level++;
        }
    }
}
