using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour
{
    public int grid_size;
    public float buffer;
    public GameObject land_plot_prefab;

    Vector3 land_size;

	void Start () 
	{
        land_size = land_plot_prefab.GetComponent<Renderer>().bounds.size;

        float land_x = land_size.x + buffer;
        float land_z = land_size.z + buffer;

        for (float ii = -grid_size * land_x / 4f; ii < grid_size * land_x  / 4f; ii += land_size.x)
        {
            for (float jj = -grid_size * land_z / 4f; jj < grid_size * land_z / 4f; jj += land_size.z)
            {
                Vector3 location = new Vector3(ii + buffer, 0f, jj + buffer);
                Instantiate(land_plot_prefab, location, land_plot_prefab.transform.rotation);
            }
        }
	}
}
