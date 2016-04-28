using UnityEngine;
using System.Collections;

public class Animator_player : MonoBehaviour {
    GameObject AoE;
    Animator anim;

	// Use this for initialization
	void Start () {
        
        anim = GetComponentInParent<Animator>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            anim.SetBool("Attack", true);

        }

        
            
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            anim.SetBool("Attack", false);
        }
    }
}
