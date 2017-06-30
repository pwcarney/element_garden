﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {

    public GameObject raindrop;

    float rain_delay = 0.05f;
    float next_drop = 0f;

    public void Rain()
    {
        if (Time.timeSinceLevelLoad > next_drop)
        {
            next_drop = Time.timeSinceLevelLoad + rain_delay;

            Vector3 cloud_pos = transform.position;
            float x_offset = Random.Range(-0.3f, 0.3f);
            float z_offset = Random.Range(-0.3f, 0.3f);
            cloud_pos.x += x_offset;
            cloud_pos.y -= 0.5f;
            cloud_pos.z += z_offset;

            Instantiate(raindrop, cloud_pos, Quaternion.identity);
        }
    }
}
