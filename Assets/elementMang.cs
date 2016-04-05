using UnityEngine;
using System.Collections;
using System;


public class elementMang : MonoBehaviour {
    public playerInv inv;
    public GameObject player;
    public GameObject[] element;
    private bool ab;
    private int count;
    
	// Use this for initialization
	void Start () {
        
        element = GameObject.FindGameObjectsWithTag("element");
        Debug.Log("There are " + element.Length + " elements on the map");
        player = GameObject.FindWithTag("Player");
        inv = player.GetComponent<playerInv>();
      
       /* for (int i = 0; i < 3; i++)
        {
            ab=inv.getElement(i);
            if (ab == true && i == 0)
            {
                Debug.Log("Player has Fire");
            }
            else if(ab==false && i==0)
                Debug.Log("Player doesn't have Fire");
            if (ab == true && i == 1)
            {
                Debug.Log("Player has Water");
            }
            else if (ab == false && i == 1)
                Debug.Log("Player doesn't have Water");
            if (ab == true && i == 2)
            {
                Debug.Log("Player has Electricity");
            }
            else if (ab == false && i == 2)
                Debug.Log("Player doesn't have Electricity");
            if (ab == true && i == 3)
            {
                Debug.Log("Player has Earth");
            }
            else if (ab == false && i == 3)
                Debug.Log("Player doesn't have Earth");
        }*/
        count = element.Length;
        	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        
        
	}

    public GameObject getElement(int inp)
    {
        return element[inp];
    }
    public int getTotalelements()
    {
        return element.Length;
    }
    
   
 

    

}
