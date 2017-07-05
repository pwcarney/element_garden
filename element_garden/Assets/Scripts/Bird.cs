using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public float bird_speed;
    public float min_dist_to_plant;

    GameObject target;

	// Use this for initialization
	void Start ()
    {
        // TODO: Make "plant" maybe
        GameObject[] potential_targets = GameObject.FindGameObjectsWithTag("Seed");

        if (potential_targets.Length == 0)
        {
            Destroy(this.gameObject);
            return;
        }
            
        target = potential_targets[Random.Range(0, potential_targets.Length)];
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > min_dist_to_plant)
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, bird_speed * Time.deltaTime);
    }
}
