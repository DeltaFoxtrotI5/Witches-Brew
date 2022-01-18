using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikekill : MonoBehaviour
{
    public Animator ani;
    private GameObject me;

      if (collision.gameObject.tag == "Player") 
        {
         ani.Play("DestroyC");
            //Debug.Log(collision.gameObject.tag + "====================================================================");
            me = collision.gameObject;
            // Destroy(me);
            Invoke("kill", 2f);
}
        
           
     


}
