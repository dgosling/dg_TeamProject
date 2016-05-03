using UnityEngine;
using System.Collections;



public class enemydamage : MonoBehaviour {
	GameObject player,right,left,feet;
	public float damage;
	health value;
    
	private float thealth1, thealth2,glob;
	private GameObject refer;
	//public double health;
	// Use this for initiaelization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player"); 
        refer = GameObject.Find ("HealthBar");
		value = refer.GetComponent<health> ();
        right = GameObject.FindGameObjectWithTag("right");
        left = GameObject.FindGameObjectWithTag("left");
        feet = GameObject.FindGameObjectWithTag("feet");
        
    }
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<BoxCollider2D>().IsTouching(right.GetComponent<BoxCollider2D>())|| GetComponent<BoxCollider2D>().IsTouching(left.GetComponent<BoxCollider2D>()))
        {
			thealth1 = value.getchealth()-damage;
			thealth2 = value.getmaxhealth();
			value.setchealth (thealth1);
			glob = thealth1/thealth2;
			value.setBar (glob);
            if (player.GetComponent<Transform>().localScale.x == .25)
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2 (-1000,0));
            if (player.GetComponent<Transform>().localScale.x == -.25)
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000, 0));
        }

        if (GetComponent<BoxCollider2D>().IsTouching(feet.GetComponent<BoxCollider2D>()))
        {
            Destroy(gameObject);
            
        }

	}


}
