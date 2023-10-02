using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBarierToRoad : MonoBehaviour
{
    private void Awake()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Road")
        {
            transform.parent = collision.transform;
        }
        
    }
}
