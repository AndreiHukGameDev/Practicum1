using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject road;
    public GameObject car;
    private List<GameObject> roads = new List<GameObject>();
    public float maxSpeed = 10f;
    private float speed = 0f;
    public int maxCountRoads = 4;
    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
        StartLevel();

    }
    private void FixedUpdate()
    {
        maxSpeed += 0.01f;
    }
    private void StartLevel()
    {
        speed = maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed == 0)
        {
            return;
        }
        foreach (GameObject road in roads) 
        {
            road.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
            
        }

        if (roads[0].transform.position.z < car.transform.position.z)
        {
            Destroy(roads[0]);
            roads.RemoveAt(0);

            CreateNextRoad();
        }
    }
    public void ResetLevel()
    {
        speed = 0f;
        while (roads.Count > 0)
        {
            Destroy(roads[0]);
            roads.RemoveAt(0);
        }
        for (int i = 0; i < maxCountRoads; i++)
        {
            CreateNextRoad();
        }
    }

    private void CreateNextRoad()
    {
        Vector3 pos = Vector3.zero;
        if (roads.Count > 0)
        {
            pos = roads[roads.Count - 1].transform.position + new Vector3(0, 0, 20);
        }
        GameObject go = Instantiate(road, pos, Quaternion.identity);
        go.transform.SetParent(transform);
        go.transform.Rotate(0, 90, 0);
        roads.Add(go);
    }
}
