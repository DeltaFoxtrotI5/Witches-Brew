using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : MonoBehaviour
{
    private float attackDamage = 10f;
    //  private float attackSpeed = 1f;
    //  private float canAttack;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (gameObject.tag == "player)")
        {
            // if (attackSpeed <= canAttack)
            //  {
            gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
            //    canAttack = 0f;
            //  }
            // else
            // {
            //     canAttack += Time.deltaTime;
            //}

        }
    }
}
