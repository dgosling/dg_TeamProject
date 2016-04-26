using UnityEngine;
using System.Collections;

public class grapple : MonoBehaviour {
    DistanceJoint2D joint;
    playerInv inv;
    public LineRenderer line;
    RaycastHit2D ray;
    public float max;
    Vector3 curpos;
    public LayerMask mask;
    public float step;
	// Use this for initialization
	void Start () {
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
        line.enabled = false;
        inv = GetComponent<playerInv>();
	}
	
	// Update is called once per frame
	void Update () {
        if (joint.distance > 1f)
            joint.distance -= step;
        
        else
        {
            line.enabled = false;
            joint.enabled = false;
        }
        line.SetPosition(0, transform.position);
        line.SetPosition(1, ray.point);
        if(GetComponent<Transform>().localScale.x==1)
        {
            curpos.x = transform.position.x + max;
            curpos.y = transform.position.y + max;
            curpos.z = 0;
        }
        if(GetComponent<Transform>().localScale.x==-1)
        {
            curpos.x = transform.position.x - max;
            curpos.y = transform.position.y + max;
            curpos.z = 0;
        }
        if (Input.GetButtonDown("grapple") == true && inv.getElement(3) == true && GetComponent<Transform>().localScale.x == 1)
        {
            ray = Physics2D.Raycast(transform.position, curpos - transform.position,max,mask);
            if(ray.collider!=null)
            {
                joint.enabled = true;
                joint.connectedBody = ray.collider.gameObject.GetComponent<Rigidbody2D>();
                joint.distance = Vector2.Distance(transform.position, ray.point);
                line.enabled = true;
                
            }
            
        }
        if (Input.GetButtonDown("grapple") == true && inv.getElement(3) == true && GetComponent<Transform>().localScale.x == -1)
        {
            
            ray = Physics2D.Raycast(transform.position, curpos, 10, mask);
            if (ray.collider != null)
            {
                joint.enabled = true;
                joint.connectedBody = ray.collider.gameObject.GetComponent<Rigidbody2D>();
                joint.distance = Vector2.Distance(transform.position, ray.point);
                line.enabled = true;

            }

        }
        if (Input.GetButtonUp("grapple") == true)
        {
            joint.enabled = false;
            line.enabled = false;
        }
        

    }
}
