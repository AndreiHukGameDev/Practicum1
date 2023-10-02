using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TempleFoolowPl : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3 (0, 5, -10);
    public Transform pos;



    
    void Start()
    {
        //var rotation = transform.eulerAngles;
        //rotation.x += angles;
        //transform.eulerAngles = rotation;


        //transform.Rotate(10,0, 0);
        //transform.rotation = Quaternion.Euler(0.5f, 0, 0);
        //transform.position = player.transform.position + offset;

        transform.LookAt(pos);

    }
    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation;
        
    }
    private void FixedUpdate()
    {
        //transform.LookAt(pos);
        transform.position = player.transform.position + offset;

    }
}
