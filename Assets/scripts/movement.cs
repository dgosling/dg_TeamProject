using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    public float jumph;
    public float moveSpeed;
    private Rigidbody2D rigid;
    bool grounded = false;
    GameObject feet,left,right;
    collMan ft, lft, rt;
    bool wallc = false;
    bool jump;
    float hor;
    Animator play;

    
    

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        feet = GameObject.FindGameObjectWithTag("feet");
        left = GameObject.FindGameObjectWithTag("left");
        right = GameObject.FindGameObjectWithTag("right");
        ft = feet.GetComponent<collMan>();
        lft = left.GetComponent<collMan>();
        rt = right.GetComponent<collMan>();
        play = GetComponent<Animator>();
        
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
            GetComponent<Transform>().localScale = new Vector3(0.25f, .25f, 1);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<Transform>().localScale = new Vector3(-.25f, .25f, 1);
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
            play.SetBool("jump", false);
            play.SetBool("on",true);
            
            return true;
            
        }



        play.SetBool("on", false);
        play.SetBool("jump", true);

        

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



