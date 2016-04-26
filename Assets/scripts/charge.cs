using UnityEngine;
using System.Collections;

public class charge : MonoBehaviour {
    public GameObject player,wall,lside,rside;
    public playerInv playerinv;
    public movement move;
    public float cspeed,dif,cposx,endposx;
    public bool incharge,pos,neg;
    public collMan lcolman,rcolman;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerinv = player.GetComponent<playerInv>();
        move = player.GetComponent<movement>();
        cspeed = move.getMspeed() * 2;
        //incharge = false;
        lside = GameObject.FindGameObjectWithTag("left");
        rside = GameObject.FindGameObjectWithTag("right");
        lcolman = lside.GetComponent<collMan>();
        rcolman = rside.GetComponent<collMan>();
        dif = 10;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if(Input.GetButtonDown("Fire3")&&playerinv.getElement(2)==true)
        {
           
            cposx = player.GetComponent<Transform>().position.x;
            
            if(player.GetComponent<Transform>().localScale.x==1)
            {
                endposx = cposx + dif;
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2(cspeed*100,1));

                incharge = true;
                pos = true;
            }
            else if(player.GetComponent<Transform>().localScale.x==-1)
            {
                endposx = cposx - dif;
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2((-1*cspeed)*100, 1));

                incharge = true;
                neg = true;
            }
        
            
        }
	}

    void Update()
    {
        if(incharge==true)
        {
            if(lcolman.getInCollision()==true||rcolman.getInCollision()==true)
            {
                if(lcolman.getGameObject().tag=="breakable"|| lcolman.getGameObject().tag =="enemy")
                {
                    wall = lcolman.getGameObject();
                    Destroy(wall);
                }
                if (rcolman.getGameObject().tag == "breakable" || rcolman.getGameObject().tag == "enemy")
                {
                    wall = rcolman.getGameObject();
                    Destroy(wall);
                }

                if (move.checkWall() == true)
                    incharge = false;

            }
            if(player.GetComponent<Transform>().position.x>=endposx&&pos==true)
            {
                pos = false;
                incharge = false;

            }
            if(player.GetComponent<Transform>().position.x<endposx&&pos==true)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2(cspeed*100, 0));
            }
            if (player.GetComponent<Transform>().position.x <= endposx && neg == true)
            {
                neg = false;
                incharge = false;
                
            }
            if (player.GetComponent<Transform>().position.x > endposx && neg == true)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2((-1*cspeed)*100, 0));
            }

        }
    }
}
