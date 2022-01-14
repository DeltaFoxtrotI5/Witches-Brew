using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public Animator ani;
    public Animator ani2;
    private GameObject me;


    // public int health;
    // public int xp;
    //public GameObject theShip;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            ani.Play("Attack");
            Debug.Log(collision.gameObject.tag + "====================================================================");
            me = collision.gameObject;
            // Destroy(me);
            // Invoke("kill", 1f);


        }
        if (collision.gameObject.tag == "Player")
        {
            ani2.Play("DestroyC");
            //Debug.Log(collision.gameObject.tag + "====================================================================");
            me = collision.gameObject;
            // Destroy(me);
            Invoke("kill", 2f);


        }


    }
    public void kill()
    {
        Destroy(me);
    }
}
