using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerInv : MonoBehaviour {
    List<string> elements = new List<string>();
    public bool acquire;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool checkInv(string inp)
    {
       acquire = elements.Contains(inp);
        return acquire;
    }
    public void setInv(string inpp)
    {
        elements.Add(inpp);
    }
}
