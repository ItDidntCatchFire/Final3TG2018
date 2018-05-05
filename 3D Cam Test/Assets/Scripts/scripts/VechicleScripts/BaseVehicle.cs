using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseVehicle : MonoBehaviour
{
    public int Score;
    private PointSystem pointSystem;
    
    // Use this for initialization
    void Start()
    {
        GameObject engine = GameObject.Find("Engine");
        pointSystem = engine.GetComponent<PointSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PegMan")
        {
            pointSystem.Points += Score;

            if (Score == 0)
                Destroy(transform.root.gameObject);

            if (Score > 0)
                Score--;
        }
    }

    void Move()
    {
        transform.Translate(new Vector3(-10, 0, 0) * Time.deltaTime);
    }
}
