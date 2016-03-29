using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
    public GameObject player;
    private bool check=false;
    private Vector3 coords;


	// Use this for initialization
	void Start () {
        	}
	
	// Update is called once per frame
	void Update () {
        coords.x=player.GetComponent<Transform>().position.x;
        coords.y = player.GetComponent<Transform>().position.y;
        if (GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>()))
        {
            GetComponent<Transform>().position = new Vector3(coords.x, coords.y, 0);
            check = true;
        }

    if(check==true)
        {
            GetComponent<Transform>().position = new Vector3(coords.x, coords.y, 0);
        }
	}
}
