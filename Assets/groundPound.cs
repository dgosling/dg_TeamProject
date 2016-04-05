using UnityEngine;
using System.Collections;

public class groundPound : MonoBehaviour {
    public GameObject player;
    public float height, velo, downwardsForce,time,cvelo;
    public playerInv inv;
    


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        inv = player.GetComponent<playerInv>();
        
	}
	void Update()
    {
        if(player.GetComponent<Rigidbody2D>().velocity.x>0)
        {
            cvelo = player.GetComponent<Rigidbody2D>().velocity.x;
        }
    }
	// Update is called once per frame
	void FixedUpdate () {
        StartCoroutine(gpound());
        
	}

    IEnumerator gpound()
    {
        if (Input.GetButtonDown("Fire2") && inv.getElement(0) == true)
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            if (cvelo > 0)
            {
                player.GetComponent<Transform>().Translate(new Vector3(+velo, +0));
            }
                if (cvelo < 0)
                player.GetComponent<Transform>().Translate(new Vector3(-velo, +0));
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(+velo, +height);

            yield return new WaitForSeconds(time);
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, -(downwardsForce));
        }
    }
    
    
}
