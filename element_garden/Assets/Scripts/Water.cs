using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Element
{
    public GameObject cloud_prefab;

    float cloud_speed = 1f;
    float float_delay = 1f;

    GameObject cloud;
    float float_away_time;

    new void Start()
    {
        cloud = Instantiate(cloud_prefab, new Vector3(0f, 5f, 0f), Quaternion.identity);

        // This class has its own Start, but we want to call Element's Start method as well!
        base.Start();
    }

    new void FixedUpdate()
    {
        base.FixedUpdate();

        if (Time.timeSinceLevelLoad > float_away_time)
        {
            Vector3 cloud_pos = cloud.transform.position;

            Vector3 new_cloud_pos = cloud_pos;
            new_cloud_pos.y = 5f;

            cloud.transform.position = Vector3.MoveTowards(cloud_pos, new_cloud_pos, cloud_speed * Time.deltaTime);
        }
    }

    protected override void Execute(Vector3 inputPos)
    {
        float_away_time = Time.timeSinceLevelLoad + float_delay;

        Vector3 cloud_pos = cloud.transform.position;

        Vector3 new_cloud_pos = inputPos;
        new_cloud_pos.y = 3f;
        cloud.transform.position = Vector3.MoveTowards(cloud_pos, new_cloud_pos, cloud_speed * Time.deltaTime);

        if (cloud_pos.y < 3.1f)
        {
            cloud.GetComponent<Cloud>().Rain();
        }
    }
}
