using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerInv : MonoBehaviour {
    public bool[] elements;


	// Use this for initialization
	void Start () {
        elements = new bool[4];
        Debug.Log("created elements with 4 index");
        elements[0] = false;
        Debug.Log("set 1st index to false");
        elements[1] = false;
        Debug.Log("set 2nd index to false");
        elements[2] = false;
        Debug.Log("set 3rd index to false");
        elements[3] = false;
        Debug.Log("set 4th index to false");



    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setElement(int a, bool b)
    {
        elements[a] = b;

    }

    /*public bool getElement(int a)
    {
        return elements[a];
    }*/
    
}
