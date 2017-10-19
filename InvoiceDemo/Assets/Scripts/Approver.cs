using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approver : MonoBehaviour {

    public Color newColor;
    public int Approve;                                         //0 = not evaluated, 1 = rejected, 2 = approved

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Invoice>().Approved == 0)                //only approve/reject if it has not been touched
        {
            collision.GetComponentInChildren<SpriteRenderer>().color = newColor;        //change the color
            collision.GetComponent<Invoice>().Approved = Approve;                       //record approval
        }
    }

}
