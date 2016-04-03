using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class SavePuntuacion : MonoBehaviour {

	private TextMesh VidasText;
	private int vidas;
	private TextMesh puntuacionText;
	private bool escrito = false;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		VidasText = GameObject.FindGameObjectWithTag ("Vidas").GetComponent<TextMesh>();
		vidas = Convert.ToInt32(VidasText.text);
		puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		if (vidas == 0 && escrito == false) {
			using (StreamWriter sw = File.AppendText("Puntuaciones.txt")) {
				sw.WriteLine (puntuacionText.text);
				escrito = true;
			}
		}

	}
}
