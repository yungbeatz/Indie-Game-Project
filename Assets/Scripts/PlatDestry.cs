using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatDestry : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {

            Destroy(collision.gameObject, 1f);
        }
    }
}
