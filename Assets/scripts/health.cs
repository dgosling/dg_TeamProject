using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {

	public float maxhealth = 100f;
	public float chealth=0f;
	public GameObject healthbar;
	public float healthdec;


	// Use this for initialization
	void Start () {
		chealth = maxhealth;
		setBar (chealth/maxhealth);
		//InvokeRepeating ("debug_dec", 1f,1f);
	}
	
	// Update is called once per frame
	void Update () {
		healthdec = chealth / maxhealth;
		setBar (healthdec);
		
	}

	/*void debug_dec(){
		chealth -= 2f;
		healthdec = chealth / maxhealth;
		setBar (healthdec);*/

	public float getchealth(){
		return chealth;
	}

	public float getmaxhealth(){
		return maxhealth;
	}
	public void setchealth(float inp){
		chealth = inp;
	}


	public void setBar(float myhealth){
		
		
		healthbar.transform.localScale = new Vector3 (myhealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
	}
}
