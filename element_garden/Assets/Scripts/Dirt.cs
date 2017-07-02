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

                // We don't want seeds on the sides of blocks. Force to top.
                Vector3 potential_position = new Vector3(inputPos.x, thing.transform.localScale.y / 2f, inputPos.z);

                GameObject seed = Instantiate(seed_prefab, potential_position, Quaternion.identity);
                seed.transform.Rotate(0f, Random.Range(0f, 360f), 0f);
            }
        }
    }
}
