using UnityEngine;
using System.Collections;
using System;

public class Vida : MonoBehaviour {

	private TextMesh puntuacionText;
	private int puntuacion;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(){
		Destroy (this.gameObject);
		puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
			puntuacion = Convert.ToInt32(puntuacionText.text);
			puntuacion = puntuacion + 1;
			puntuacionText.text = puntuacion+"";
	}
}
