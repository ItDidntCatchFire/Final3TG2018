using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiclesSpawner : MonoBehaviour
{

    private Object[] Vehicles;
    private Vector3 startlocation1, startlocation2;

    private bool Test = false;
    // Use this for initialization
    void Start()
    {
        Vehicles = Resources.LoadAll("Prefab/Vehicles", typeof(GameObject));

        startlocation1 = GameObject.Find("Tunnel1").transform.position;
        startlocation1.y += 18;
        startlocation1.x -= 2;

        startlocation2 = GameObject.Find("Tunnel2").transform.position;
        startlocation2.y += 18;
        startlocation2.x -= 2;

        InvokeRepeating("MakeVehicles", 0.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MakeVehicles()
    {
        Instantiate(Vehicles[Random.Range(0, Vehicles.Length)], startlocation1, Quaternion.identity);
        Instantiate(Vehicles[Random.Range(0, Vehicles.Length)], startlocation2, Quaternion.Euler(0, 180, 0));
    }
}
