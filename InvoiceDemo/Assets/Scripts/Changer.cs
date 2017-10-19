using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour {

    public Sprite newSkin;
    public GameObject smoke;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Invoice")
        {
           if(collision.gameObject.GetComponent<SpriteRenderer>() && collision.GetComponent<Invoice>().Approved==2)
            {
                collision.GetComponent<SpriteRenderer>().sprite = newSkin;
                collision.GetComponent<SpriteRenderer>().color = Color.white;
            }
           else
            {
                Debug.Log("Let's blow it up!");
                collision.GetComponent<Invoice>().Die();
            }
        }
    }

}
