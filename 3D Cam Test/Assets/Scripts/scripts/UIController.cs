using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text txtPoints;
    public GameObject player;

    private PointSystem pointSystem;

    // Use this for initialization
    void Start () {
        GameObject engine = GameObject.Find("Engine");
        pointSystem = engine.GetComponent<PointSystem>();

    }
	
	// Update is called once per frame
	void Update () {
        txtPoints.text = "Points: " + pointSystem.Points;
    }
}
