using UnityEngine;
using System.Collections;
using System;

public class TorretaBoss1 : MonoBehaviour {

	private TextMesh puntuacionText;
	private int puntuacion;
	private float rotationX, rotationY, rotationZ;
	private GameObject generadorEnemigos;

	// Use this for initialization
	void Start () {
		rotationX = this.transform.rotation.x;
		rotationY = this.transform.rotation.y;
		rotationZ = this.transform.rotation.z;
		generadorEnemigos = GameObject.FindGameObjectWithTag ("GeneradorEnemigos");
	}

	// Update is called once per frame
	void Update () {
		this.transform.rotation = Quaternion.Euler (rotationX,rotationY,rotationZ++);
		Destruccion ();
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
		puntuacion = puntuacion + 100;
		puntuacionText.text = puntuacion+"";
		InfoBoss1.setEliminado (true);
		generadorEnemigos.GetComponent<GeneradorEnemigos> ().activo2 = true;
		generadorEnemigos.GetComponent<GeneradorEnemigos> ().activo = true;
	}

	void SaveBossMode (){
		
	}
}
