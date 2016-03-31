using UnityEngine;
using System.Collections;


public class pickup : MonoBehaviour {
   
    public playerInv at = new playerInv();
    public string element;
    private string fire, water, ele, earth;

	// Use this for initialization
	void Start () {
        fire = "Fire";
        water = "Water";
        ele = "Electricity";
        earth = "Earth";
        	}
	
	// Update is called once per frame
	void Update () {
        
        
	}
    void OnCollisionEnter(Collision col)
    {
        
        if(fire == col.gameObject.name)
        {
            at.setInv(fire);
            Debug.Log("added fire");
        }
        else if (water == col.gameObject.name)
        {
            at.setInv(water);
            Debug.Log("added water");
        }
        else if (ele == col.gameObject.name)
        {
            at.setInv(ele);
            Debug.Log("added ele");
        }
        else if (earth == col.gameObject.name)
        {
            at.setInv(earth);
            Debug.Log("added earth");
        }

    }

}
