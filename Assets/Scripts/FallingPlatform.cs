using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class FallingPlatform : MonoBehaviour
 {

    public Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine("falldown");
        }
        
    }
    
    IEnumerator falldown()
    {
        yield return new WaitForSeconds(0.05f);
        rb.isKinematic = false;
       
    }
}
