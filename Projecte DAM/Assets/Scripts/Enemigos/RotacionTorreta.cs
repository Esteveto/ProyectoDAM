using UnityEngine;
using System.Collections;
using System;


public class RotacionTorreta : MonoBehaviour {

	//Script para las rotaciones de las torretas
	private TextMesh puntuacionText;
	private int puntuacion;
	private float rotationX, rotationY, rotationZ;

	// Use this for initialization
	void Start () {
		rotationX = this.transform.rotation.x;
		rotationY = this.transform.rotation.y;
		rotationZ = this.transform.rotation.z;	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 1) {
			this.transform.rotation = Quaternion.Euler (rotationX,rotationY,rotationZ++);
			Destruccion ();
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
		puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		puntuacion = Convert.ToInt32(puntuacionText.text);
		puntuacion = puntuacion + 10;
		puntuacionText.text = puntuacion+"";
	}
}
