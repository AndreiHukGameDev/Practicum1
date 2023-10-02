using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private float speed = 2.5f;
    public GameObject firstMarker;
    public GameObject player;
    
    private Vector3 offset = new Vector3 (0, 5, -25);

    
    void LateUpdate()
    {
        try
        {
            transform.position = firstMarker.transform.position;

            firstMarker.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (transform.position.z >= -20f)
            {

                Destroy(GameObject.Find("Cube"));
            }
        }
        catch (System.Exception)
        {

            transform.position = player.transform.position + offset;
        }
    }
}
