using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour {

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Raindrop")
            Destroy(this.gameObject);
    }
}
