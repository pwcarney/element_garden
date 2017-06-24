using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public int grid_size;
    public float buffer;
    public GameObject land_plot_prefab;

    Vector3 land_size;

	void Start () 
	{
        /*
        land_size = land_plot_prefab.GetComponent<Renderer>().bounds.size;

        for (double ii = -grid_size / 2.0; ii < grid_size / 2.0; ii += land_size.x + buffer)
        {
            for (double jj = -grid_size / 2.0; jj < grid_size / 2.0; jj += land_size.z + buffer)
            {
                Vector3 location = new Vector3((float)ii + buffer, (float)0.0, (float)jj + buffer);
                Instantiate(land_plot_prefab, location, Quaternion.identity);
            }
        }*/
	}
}
