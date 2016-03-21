using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    public float jumph;
    public float moveSpeed;
    private Rigidbody2D rigid;
    public bool grounded = false;
    public LayerMask groundM, wallM;
    public bool wallc = false;
    public bool jump;
    public float hor;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

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
            Collider2D[] groundObjs = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y - transform.GetComponent<BoxCollider2D>().size.y / 2) * transform.localScale.y, 0.01f, groundM);
            if (groundObjs.Length > 0)
            {
                return true;
            }

        groundObjs = Physics2D.OverlapCircleAll(new Vector2((transform.position.x - transform.GetComponent<BoxCollider2D>().size.x / 2) * transform.localScale.x, transform.position.y - transform.GetComponent<BoxCollider2D>().size.y / 2) * transform.localScale.y, 0.01f, groundM);
        if (groundObjs.Length > 0)
        {
            return true;
        }
        groundObjs = Physics2D.OverlapCircleAll(new Vector2((transform.position.x + transform.GetComponent<BoxCollider2D>().size.x / 2) * transform.localScale.x, transform.position.y - transform.GetComponent<BoxCollider2D>().size.y / 2) * transform.localScale.y, 0.01f, groundM);
        if (groundObjs.Length > 0)
        {
            return true;
        }





        return false;
    }

        bool cWall()
    {
            Collider2D[] wallObjs = Physics2D.OverlapCircleAll(new Vector2(transform.position.x - transform.GetComponent<BoxCollider2D>().size.x / 2 * transform.localScale.x + -0.01f, transform.position.y), 0.01f, wallM);
            
        if (wallObjs.Length != 0)
            {
                return true;
            }

        wallObjs = Physics2D.OverlapCircleAll(new Vector2(transform.position.x - transform.GetComponent<BoxCollider2D>().size.x / 2 * transform.localScale.x , transform.position.y), 0.01f, wallM);
        if (wallObjs.Length != 0)
        {
            return true;
        }

        wallObjs = Physics2D.OverlapCircleAll(new Vector2(transform.position.x + transform.GetComponent<BoxCollider2D>().size.x / 2 * transform.localScale.x , transform.position.y), 0.01f, wallM);
        if (wallObjs.Length != 0)
        {
            return true;
        }
        return false;



        }

        void OnDrawGizmos()
    {
            Gizmos.DrawSphere(new Vector3(transform.position.x, transform.position.y - transform.GetComponent<BoxCollider2D>().size.y / 2 * transform.localScale.y, 0.0f),0.01f);
        Gizmos.DrawSphere(new Vector3(transform.position.x - transform.GetComponent<BoxCollider2D>().size.x / 2 * transform.localScale.x , transform.position.y, 0.0f), 0.01f);
        Gizmos.DrawSphere(new Vector3(transform.position.x + transform.GetComponent<BoxCollider2D>().size.x/2  * transform.localScale.x , transform.position.y, 0.0f), 0.01f);
        Gizmos.DrawSphere(new Vector3((transform.position.x - transform.GetComponent<BoxCollider2D>().size.x / 2) * transform.localScale.x, (transform.position.y - transform.GetComponent<BoxCollider2D>().size.y / 2) * transform.localScale.y - 0.01f), 0.01f);
        Gizmos.DrawSphere(new Vector3((transform.position.x + transform.GetComponent<BoxCollider2D>().size.x / 2) * transform.localScale.x, (transform.position.y - transform.GetComponent<BoxCollider2D>().size.y / 2) * transform.localScale.y - 0.01f), 0.01f);

    }


    }

