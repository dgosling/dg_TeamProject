using UnityEngine;
using System.Collections;

public class elePickup : MonoBehaviour {
    public playerInv inv;
    public elementMang mang;
    public GameObject pickup,player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        mang = player.GetComponent<elementMang>();
        inv = player.GetComponent<playerInv>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
