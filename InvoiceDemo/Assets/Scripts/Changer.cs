using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour {

    public Sprite newSkin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Invoice")
        {
           if(collision.gameObject.GetComponent<SpriteRenderer>())
            {
                collision.GetComponent<SpriteRenderer>().sprite = newSkin;
            }
           else
            {
                Debug.Log("No renderer found!");
            }
        }
    }

}
