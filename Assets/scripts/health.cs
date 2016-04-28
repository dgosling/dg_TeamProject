using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour {

	public float maxhealth;
	float chealth;
	public GameObject healthbar,ply;
	float healthdec;
    Scene sc;

	// Use this for initialization
	void Start () {
		chealth = maxhealth;
		setBar (chealth/maxhealth);
        ply = GameObject.FindGameObjectWithTag("Player");
        //InvokeRepeating ("debug_dec", 1f,1f);
        sc = SceneManager.GetActiveScene();
	}
	
	// Update is called once per frame
	void Update () {
		healthdec = chealth / maxhealth;
		setBar (healthdec);
        if(chealth<=0)
        {
            Destroy(ply);
            SceneManager.LoadScene(sc.name);
        }
		
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
