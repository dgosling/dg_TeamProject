using UnityEngine;
using System.Collections;

public class groundPound : MonoBehaviour {
    public GameObject player,brkwll;
    public float height, velo, downwardsForce,cpos,pos;
    public Vector2 cvelo;
    public playerInv inv;
    private bool inGP;
    public collMan collman;
    


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        brkwll = GameObject.FindGameObjectWithTag("breakable");
        inv = player.GetComponent<playerInv>();
        collman = player.GetComponent<collMan>();
        
	}
	void Update()
    {
        cvelo = player.GetComponent<Rigidbody2D>().velocity;
        if ((player.GetComponent<Rigidbody2D>().velocity.y == 0 || player.GetComponent<Rigidbody2D>().velocity.y > 0) && inGP == true && collman.getInCollision() == true && collman.getGameObject() == brkwll)
        {
            Debug.Log("detected collision and destroying wall");
            Destroy(brkwll);
        }
        if (player.GetComponent<Rigidbody2D>().velocity.y == 0 && inGP == true)
        {
            inGP = false;
            Debug.Log("set to "+inGP);
        }
        
    }
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetButtonDown("Fire2") && inv.getElement(0) == true)
        {
            
            
            
            

            player.GetComponent<Rigidbody2D>().velocity = new Vector2(+0,-downwardsForce);
            Debug.Log("added force");
            inGP = true;
            Debug.Log("set inGP to " + inGP);

           


        }

    }

    
    
    
}
