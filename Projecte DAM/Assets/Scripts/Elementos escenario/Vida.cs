using UnityEngine;
using System.Collections;
using System;

public class Vida : MonoBehaviour {

	private TextMesh VidaText;
	private int vida;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			VidaText = GameObject.FindGameObjectWithTag ("Vidas").GetComponent<TextMesh>();
			vida = Convert.ToInt32(VidaText.text);
			vida = vida + 1;
			VidaText.text = vida+"";
		}

	}
}
