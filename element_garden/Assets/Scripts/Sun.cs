using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : Element {

    public GameObject sunbeam_prefab;

    float sunbeam_speed = 50f;
    float float_delay = 0f;

    GameObject sunbeam;
    float float_away_time;

    new void Start()
    {
        sunbeam = Instantiate(sunbeam_prefab, new Vector3(0f, 10f, 0f), Quaternion.identity);

        // This class has its own Start, but we want to call Element's Start method as well!
        base.Start();
    }

    new void FixedUpdate()
    {
        base.FixedUpdate();

        if (Time.timeSinceLevelLoad > float_away_time)
        {
            Vector3 sunbeam_pos = sunbeam.transform.position;

            Vector3 new_sunbeam_pos = sunbeam_pos;
            new_sunbeam_pos.y = 10f;

            sunbeam.transform.position = Vector3.MoveTowards(sunbeam_pos, new_sunbeam_pos, sunbeam_speed * Time.deltaTime);
        }
    }

    protected override void Execute(Vector3 inputPos)
    {
        float_away_time = Time.timeSinceLevelLoad + float_delay;

        Vector3 sunbeam_pos = sunbeam.transform.position;

        Vector3 new_sunbeam_pos = inputPos;

        // If the beam is right above the user's position, drop down, else align to user's position
        // Net result is that sunbeam only drops down
        if (sunbeam_pos.x == new_sunbeam_pos.x && sunbeam_pos.z == new_sunbeam_pos.z)
        {
            new_sunbeam_pos.y = 4.3f;
        }
        else
        {
            new_sunbeam_pos.y = sunbeam_pos.y;
        }
        sunbeam.transform.position = Vector3.MoveTowards(sunbeam_pos, new_sunbeam_pos, sunbeam_speed * Time.deltaTime);
    }
}
