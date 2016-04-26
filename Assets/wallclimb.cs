using UnityEngine;
using System.Collections;

public class wallclimb : MonoBehaviour {
    public GameObject player, wall;
    public playerInv inv;
    public movement move;
    public bool tog;
    public float vmove;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        inv = player.GetComponent<playerInv>();
        move = player.GetComponent<movement>();

    }
	
	// Update is called once per frame
    void Update()
    {
        vmove = Input.GetAxis("Vertical");
        if (tog == true)
        {
            
            player.GetComponent<Rigidbody2D>().gravityScale = 0;
            if(Input.GetAxis("Vertical") != 0)
            {
                player.GetComponent<Rigidbody2D>().velocity =new Vector2 (0, Input.GetAxis("Vertical") * move.getMspeed());
            }
  
        }
        if(tog==false)
        {
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
	void FixedUpdate()
    {
        if (move.checkWall()==true&&inv.getElement(2)==true)
        {
            if (Input.GetButtonDown("Fire3"))
            {
                if (tog == true)
                    tog = false;
                else
                    tog = true;
            }
           

        }
        if (move.checkWall() == false)
            tog = false;
    }
}
