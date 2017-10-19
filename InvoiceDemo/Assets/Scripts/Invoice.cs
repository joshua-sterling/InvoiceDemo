using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoice : MonoBehaviour {

    public int Approved = 0;            //0 is not reviewed, 1 = rejected, 2 = approved
    public GameObject explosion;

    public void Die()
    {
        GameObject smokePuff = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;

        ParticleSystem ps = smokePuff.GetComponent<ParticleSystem>();
        ParticleSystem.MainModule psmain = ps.main;
        Destroy(gameObject);
    }

}
