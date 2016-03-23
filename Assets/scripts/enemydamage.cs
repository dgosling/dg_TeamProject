using UnityEngine;
using System.Collections;


public class enemydamage : MonoBehaviour {
	public GameObject player;
	public float damage;
	public health value;
	private float thealth1, thealth2,glob;
	private GameObject refer;
	//public double health;
	// Use this for initiaelization
	void Start () {
		refer = GameObject.Find ("HealthBar");
		value = refer.GetComponent<health> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>())){
			thealth1 = value.getchealth()-damage;
			thealth2 = value.getmaxhealth();
			value.setchealth (thealth1);
			glob = thealth1/thealth2;
			value.setBar (glob);
		}
	}


}
