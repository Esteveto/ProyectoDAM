﻿using UnityEngine;
using System.Collections;

public class CuerpoACuerpoMovil : MonoBehaviour {

	private Rigidbody2D torretaMovil;
	private Transform player;
	public float velocidad;

	// Use this for initialization
	void Start () {
		torretaMovil = this.GetComponent<Rigidbody2D> ();
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	// Update is called once per frame
	void Update () {
		Movimiento ();
		Destruccion ();
	}

	void Movimiento(){

		this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position,0.2f );

		float z = Mathf.Atan2 ((player.transform.position.y - this.transform.position.y), (player.transform.position.x - this.transform.position.x)) * Mathf.Rad2Deg ;

		this.transform.eulerAngles = new Vector3 (0, 0, z);
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			print ("playerhit");
			//Destroy (col.gameObject);
		} else if (col.gameObject.tag == "Pared") {
			print ("pared");
		}
	}

	void Destruccion () {
		if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo (0).IsName ("DestruccionEnemigo") == true) {
			StartCoroutine (KillOnAnimationEnd());
		}
	}

	private IEnumerator KillOnAnimationEnd() {
		yield return new WaitForSeconds (0.167f);
		Destroy (gameObject);
	}
}
