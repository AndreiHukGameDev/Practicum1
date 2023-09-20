using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    void Start()
    {
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed += 0.2f * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * (speed * 6) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * (speed * 6) * Time.deltaTime);

        }
        Debug.Log(speed.ToString());
        
    }
}
