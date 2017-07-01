using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

    bool m_has_seed = false;

    public bool has_seed
    {
        get { return this.m_has_seed; }
        set { this.m_has_seed = value; }
    }
}
