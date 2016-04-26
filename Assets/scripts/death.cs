using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {

    GameObject ply;

	// Use this for initialization
	void Start () {
        ply = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<BoxCollider2D>().IsTouching(ply.GetComponent<BoxCollider2D>()))
        {
            Destroy(gameObject);

        }
	}
}
