using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public Rigidbody rb;
    bool force = false;
    public float forwardForce = 400f;
    public float sidewaysForce = 60f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            force = true;
        }

        if (force == true)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if (rb.position.y < -2f)
        {
            Invoke("freeze", 1f);
        }

        if (rb.position.x > 7.5)
        {
            Invoke("freeze", 1f);
        }

        if (rb.position.x < -7.5)
        {
            Invoke("freeze", 1f);
        }
    }

    void freeze ()
    {
        rb.constraints = RigidbodyConstraints.FreezePosition;
        FindObjectOfType<GameManager>().EndGame();
    }

}
