using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    public int bird_cooldown;
    public GameObject bird_prefab;

    float last_bird = 0f;

	// Update is called once per frame
	void Update ()
    {
		if (Time.timeSinceLevelLoad > last_bird)
        {
            last_bird += Time.timeSinceLevelLoad + bird_cooldown;

            float x_spawn = Random.Range(-3.5f, 3.5f);
            float z_spawn = Random.Range(-3.5f, 3.5f);
            Instantiate(bird_prefab, new Vector3(x_spawn, 5f, z_spawn), Quaternion.identity);
        }
	}
}
