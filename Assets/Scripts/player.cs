using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;
    public float magnitude;
    public float jumpForce;
    public bool canJump = false;

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(movement.normalized * magnitude);

        if (Input.GetKeyDown(KeyCode.Space)&&canJump)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Trap"))
        {
            Time.timeScale = 0;
        }
    }
}