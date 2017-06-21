using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementController : MonoBehaviour
{
    Water water;
    Air air;
    Sun sun;
    Dirt dirt;

    void Start()
    {
        water = GetComponentInChildren<Water>();
        air = GetComponentInChildren<Air>();
        sun = GetComponentInChildren<Sun>();
        dirt = GetComponentInChildren<Dirt>();
    }

    void Update ()
    {
        if (Input.GetKey("w"))
        {            
            air.NotHolding();
            sun.NotHolding();
            dirt.NotHolding();    
            water.Holding();
            return;
        }
        else if (Input.GetKey("a"))
        {
            water.NotHolding();
            sun.NotHolding();
            dirt.NotHolding();
            air.Holding();
            return;
        }
        else if (Input.GetKey("s"))
        {
            water.NotHolding();
            air.NotHolding();
            dirt.NotHolding();
            sun.Holding();
            return;
        }
        else if (Input.GetKey("d"))
        {
            water.NotHolding();
            air.NotHolding();
            sun.NotHolding();
            dirt.Holding();
            return;
        }
        else
        {
            water.NotHolding();
            air.NotHolding();
            sun.NotHolding();
            dirt.NotHolding();
            return;
        }
    }
}
