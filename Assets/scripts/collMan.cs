using UnityEngine;
using System.Collections;

public class collMan : MonoBehaviour {
    public bool curCol;
    private GameObject col;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D collide) {
        col = collide.collider.gameObject;
        curCol = true;
	
	}
    void OnCollisionExit2D(Collision2D coll)
    {
        curCol = false;
    }

    public bool getInCollision()
    {
        return (curCol);
    }

    public GameObject getGameObject()
    {
        return (col);
    }
}
