using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CreateLet;

public class DestroyLet : MonoBehaviour
{
    private Vector3 distationDiferent = new Vector3 (0, 0, -20);
    private Vector3 distationDestroy;
    private GameObject car;
    
    void FixedUpdate()
    {
        car = GameObject.Find("Car");
        distationDestroy = car.transform.position + distationDiferent;
        
        if (transform.position.z <= distationDestroy.z)
        {
            Destroy(this.gameObject);
        }
    }
    
}
