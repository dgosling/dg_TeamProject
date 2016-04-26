using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    public float jumph;
    public float moveSpeed;
    private Rigidbody2D rigid;
    public bool grounded = false;
    public GameObject feet,left,right;
    public collMan ft, lft, rt;
    public bool wallc = false;
    public bool jump;
    public float hor;
    

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        feet = GameObject.FindGameObjectWithTag("feet");
        left = GameObject.FindGameObjectWithTag("left");
        right = GameObject.FindGameObjectWithTag("right");
        ft = feet.GetComponent<collMan>();
        lft = left.GetComponent<collMan>();
        rt = right.GetComponent<collMan>();
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        grounded = Cground();
        wallc = cWall();

    }


    void Movement()
    {
        rigid.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rigid.velocity.y);
        if (Input.GetAxis("Horizontal")>0)
        {
            GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        }

        jump = Input.GetButton("Jump");
        hor = Input.GetAxis("Horizontal");
        if (Input.GetButton("Jump") && grounded)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumph);
            grounded = false;
        }


        if (Input.GetButton("Jump"))
        {
            if ((rigid.velocity.x !=0) && wallc == true)
            {
                rigid.velocity = new Vector2(rigid.velocity.x, jumph);
                
            }




        }
    }
        bool Cground()
    {
        if (ft.getInCollision() == true)
        {
            return true;
        }





        return false;
    }

        bool cWall()
    {
        if (lft.getInCollision() == true || rt.getInCollision() == true)
        {
            return true;
        }

        return false;



        }

        
    public float getMspeed()
    {
        return moveSpeed;
    }
    public bool checkWall()
    {
        return wallc;
    }

    public float getHeight()
    {
        return jumph;
    }


    }



