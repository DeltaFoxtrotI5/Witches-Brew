using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTest : MonoBehaviour
{

    Animator a;

    public float movementSpeed = 1;
    public float JumpForce = 1;


    public ProgectileBehavior ProjectilePrefab;
    public Transform launchOffset;


    private Rigidbody2D _rigidbody;
    private bool grounded;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        a = gameObject.GetComponent<Animator>();

    }

    private void Update()
    {

        a.SetFloat("yVelocity", rb2.velocity);
        a.SetBool("grounded", grounded);

        float horizvalue = Input.GetAxis("Horizontal");

        if (horizvalue == 0)
        {
            a.SetBool("moving", false);
        }
        else
        {
            a.SetBool("moving", true);
        }


        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, launchOffset.position, transform.rotation);
        }

    }
}

