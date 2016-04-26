using UnityEngine;
using System.Collections;

public class geyser : MonoBehaviour {
    private GameObject pl;
    private movement move;
    private playerInv inv;
    private bool check;
    public float height;
     
	// Use this for initialization
	void Start () {
        pl = GameObject.FindGameObjectWithTag("Player");
        move = pl.GetComponent<movement>();
        inv = pl.GetComponent<playerInv>();
	}
	
	// Update is called once per frame
	void Update () {
        if (inv.getElement(1) == true && Input.GetButtonDown("Fire1"))
        {
            pl.GetComponent<Rigidbody2D>().velocity = new Vector2(+0, height);
        }
       
	
	}

   
}
