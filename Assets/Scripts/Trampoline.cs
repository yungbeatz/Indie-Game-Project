using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public Rigidbody2D rb;
   

    public float launchForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trampoline"))
        {
            rb.velocity = Vector2.up * launchForce;

        }

    }
  
}
