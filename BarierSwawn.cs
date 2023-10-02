using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BarierSwawn : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();
    float maxXposition = 6f;
    float minXposition = -6f;
    float maxZpositio = 120f;
    void Start()
    {
        AddScriptingToObject(list);
        Invoke("CreateBariers", 3);

    }
    
    public void CreateBariers()
    {
        GameObject barier = Instantiate<GameObject>(list[UnityEngine.Random.Range(0, list.Count)]);
        barier.transform.position = new Vector3(UnityEngine.Random.Range(minXposition, maxXposition), 0, UnityEngine.Random.Range(20, maxZpositio));
        Invoke("CreateBariers", 3);

    }
    private void AddScriptingToObject(List<GameObject> listOfTransport)
    {
        for (int i = 0; i < listOfTransport.Count; i++)
        {
            if (!listOfTransport[i].GetComponent<FollowBarierToRoad>())
            {
                listOfTransport[i].AddComponent<FollowBarierToRoad>();
            }

        }
    }
}
