using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool keypressed = false;
    public Rigidbody rb;
    public float force = 2000f;
    public float sideForce = 650f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, force * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            keypressed = true;
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey ("a"))
        {
            keypressed = true;
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            keypressed = true;
            rb.AddForce(0, sideForce * Time.deltaTime, 0);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
