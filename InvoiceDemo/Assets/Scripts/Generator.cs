using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject invoice;
    public float projectilespeed = -1f;
    public float fireRate = 0.2f;           //rate of fire


    private void Fire()
    {
        Vector3 startPos = transform.position;                                                 //startPOs will be in the generator
        GameObject bill = Instantiate(invoice, startPos, Quaternion.identity) as GameObject;  //instantiate as a gameobject
        bill.GetComponent<Rigidbody2D>().velocity = new Vector3(0, projectilespeed, 0);
        Debug.Log("Invoice created");

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))                                                    //player shoots laser
        {
            Fire();           //begin calling Fire method 
            Debug.Log("Space pressed");
        }
    }
}
