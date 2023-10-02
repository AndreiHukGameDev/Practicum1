using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLet : MonoBehaviour
{
    // CHANGE modificator! and add empty object!
    public GameObject player;
    private Vector3 newPos = new Vector3(0, 0, 180);
    public List<GameObject> children;
    public float timeGeneratorCars = 5f;
    void Start()
    {
        AddScriptingToObject(children);
        Invoke("CreateNewCar", timeGeneratorCars);
    }
    private void CreateNewCar()
    {
        GameObject transport = Instantiate<GameObject>(children[Random.Range(0, children.Count)]);
        transport.transform.position = player.transform.position + newPos;
        transport.transform.Rotate(0, 180, 0);
        Rigidbody rb = transport.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Invoke("CreateNewCar", timeGeneratorCars);
    }
    private void AddScriptingToObject(List<GameObject> listOfTransport)
    {
        for (int i = 0; i < listOfTransport.Count; i++)
        {
            if (!listOfTransport[i].GetComponent<MovedLet>())
            {
                listOfTransport[i].AddComponent<MovedLet>();
            }
            if (!listOfTransport[i].GetComponent<DestroyLet>())
            {
                listOfTransport[i].AddComponent<DestroyLet>();
            }
            
        }
    }
}
