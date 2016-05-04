using UnityEngine;
using System.Collections;

public class Brazo1 : MonoBehaviour {

	private GameObject disparoBrazo2;
	private PolygonCollider2D collider2;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
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
		disparoBrazo2 = InfoBoss1.getDisparo2();
		collider2 = InfoBoss1.getCollider2 ();
		disparoBrazo2.SetActive (true);
		collider2.enabled = true;
		/*puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		puntuacion = Convert.ToInt32(puntuacionText.text);
		puntuacion = puntuacion + 10;
		puntuacionText.text = puntuacion+"";*/
	}
}
