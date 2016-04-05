using UnityEngine;
using System.Collections;

public class groundPound : MonoBehaviour {
    public GameObject player;
    public double height, velo, downwardsForce;
    


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
