using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : Element
{
    public GameObject seed_prefab;
    public LayerMask ground_mask;

    protected override void Execute(Vector3 inputPos)
    {
        Collider[] hit_things = Physics.OverlapSphere(inputPos, 0.1f, ground_mask);
        foreach (Collider thing in hit_things)
        {
            if (!thing.GetComponent<Ground>().has_seed)
            {
                thing.GetComponent<Ground>().has_seed = true;

                Instantiate(seed_prefab, inputPos, Quaternion.identity);
            }
        }
    }
}
