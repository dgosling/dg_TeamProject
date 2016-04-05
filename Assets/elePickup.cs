using UnityEngine;
using System.Collections;

public class elePickup : MonoBehaviour {
    public playerInv inv;
    public elementMang mang;
    public GameObject player;
    public string nname;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        mang = player.GetComponent<elementMang>();
        inv = player.GetComponent<playerInv>();
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D collide)
    {
        nname = collide.collider.gameObject.name;
        if (nname=="Fire"||nname=="fire")
        {
            inv.setElement(0, true);
            Destroy(GameObject.Find(nname));
        }
        else if (nname == "Water" || nname == "water")
        {
            inv.setElement(1, true);
            Destroy(GameObject.Find(nname));
        }
        else if (nname == "Electricity" || nname == "electricity")
        {
            inv.setElement(2, true);
            Destroy(GameObject.Find(nname));
        }
        else if (nname == "Earth" || nname == "earth")
        {
            inv.setElement(3, true);
            Destroy(GameObject.Find(nname));
        }
        
    }
}
