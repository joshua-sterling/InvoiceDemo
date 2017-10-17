using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workflow : MonoBehaviour {

    public float turnspeed = -1f;
    
    

    private void Update()
    {
        gameObject.transform.Rotate(0,0,turnspeed);
    }
}
