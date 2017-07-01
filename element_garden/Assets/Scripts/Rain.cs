using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Raindrop")
            Destroy(this.gameObject);
    }
}
