﻿using UnityEngine;
using System.Collections;

public class PCamera : MonoBehaviour {
    GameObject plyr;
   Vector3 Coords;

	// Use this for initialization
	void Start () {
        plyr = GameObject.FindGameObjectWithTag("Player");
        Coords.x = 0;
        Coords.y = 0;
        Coords.z = -1;
	}
	
	// Update is called once per frame
	void Update () {
        Coords.x = plyr.transform.position.x+5;
        Coords.y = plyr.transform.position.y+3;

        transform.position = Coords;
	}
}
