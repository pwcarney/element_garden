using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
            Destroy(this.gameObject);
    }

    private void Update()
    {
        if (transform.position.y < -10.0)
            Destroy(this.gameObject);
    }
}
