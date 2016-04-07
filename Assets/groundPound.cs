using UnityEngine;
using System.Collections;

public class groundPound : MonoBehaviour {
    public GameObject player,brkwll;
    public float height, velo, downwardsForce,cpos,pos;
    public Vector2 cvelo;
    public playerInv inv;
    


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        brkwll = GameObject.FindGameObjectWithTag("breakable");
        inv = player.GetComponent<playerInv>();
        
	}
	void Update()
    {
        cvelo = player.GetComponent<Rigidbody2D>().velocity;
    }
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetButtonDown("Fire2") && inv.getElement(0) == true)
        {
            
            
            
            if (cvelo.x > 0) { 
                for (float ccvelo = player.GetComponent<Rigidbody2D>().velocity.x+velo; ccvelo > 0; ccvelo -= 0.5f)
                {
                    player.GetComponent<Rigidbody2D>().velocity = new Vector2(ccvelo,ccvelo);
                }
        }
            if(cvelo.x<0)
            {
                for (float ccvelo = player.GetComponent<Rigidbody2D>().velocity.x+velo; ccvelo < 0; ccvelo +=  0.5f)
                {
                    player.GetComponent<Rigidbody2D>().velocity = new Vector2(ccvelo, ccvelo);
                }
            }
            else
            {
                for (float ccvelo = player.GetComponent<Rigidbody2D>().velocity.x + velo; ccvelo > 0; ccvelo -= 0.5f)
                {
                    player.GetComponent<Rigidbody2D>().velocity = new Vector2(ccvelo, ccvelo);
                }
            }

            player.GetComponent<Rigidbody2D>().velocity = new Vector2(+0,-downwardsForce);
            if (player.GetComponent<BoxCollider2D>().IsTouching(brkwll.GetComponent<BoxCollider2D>()))
            {
                Destroy(brkwll);
            }


        }

    }

    
    
    
}
