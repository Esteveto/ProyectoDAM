using UnityEngine;
using System.Collections;

public class AccionesBoss1 : MonoBehaviour {

	private GameObject brazo1;
	private GameObject brazo2;
	private GameObject brazo3;
	private GameObject brazo4;
	private GameObject brazo5;
	private GameObject disparo1;
	private GameObject disparo2;
	private GameObject disparo3;
	private GameObject disparo4;
	private GameObject disparo5;

	// Use this for initialization
	void Start () {
		brazo1 = GameObject.FindGameObjectWithTag ("Boss1Brazo1");
		brazo2 = GameObject.FindGameObjectWithTag ("Boss1Brazo2");
		brazo3 = GameObject.FindGameObjectWithTag ("Boss1Brazo3");
		brazo4 = GameObject.FindGameObjectWithTag ("Boss1Brazo4");
		brazo5 = GameObject.FindGameObjectWithTag ("Boss1Brazo5");
		disparo1 = GameObject.FindGameObjectWithTag ("Boss1Disparo1");
		disparo2 = GameObject.FindGameObjectWithTag ("Boss1Disparo2");
		disparo3 = GameObject.FindGameObjectWithTag ("Boss1Disparo3");
		disparo4 = GameObject.FindGameObjectWithTag ("Boss1Disparo4");
		disparo5 = GameObject.FindGameObjectWithTag ("Boss1Disparo5");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
	}
}
