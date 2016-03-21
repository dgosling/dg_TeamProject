using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {

    public GameObject ply;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<BoxCollider2D>().IsTouching(ply.GetComponent<BoxCollider2D>()))
        {
            Destroy(gameObject);

        }
	}
}
