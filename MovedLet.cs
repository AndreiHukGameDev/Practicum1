using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedLet : MonoBehaviour
{
    //NEED to change modificator!
    public float speed = 30f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
}
