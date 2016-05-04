using UnityEngine;
using System.Collections;

public class Brazo2 : MonoBehaviour {

	private GameObject disparoBrazo3;
	private PolygonCollider2D collider3;
	public GameObject torretaSpawn;

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
		Instantiate (torretaSpawn,gameObject.transform.position,gameObject.transform.rotation);
		Destroy (gameObject);
		disparoBrazo3 = InfoBoss1.getDisparo3();
		collider3 = InfoBoss1.getCollider3 ();
		disparoBrazo3.SetActive (true);
		collider3.enabled = true;
		/*puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		puntuacion = Convert.ToInt32(puntuacionText.text);
		puntuacion = puntuacion + 10;
		puntuacionText.text = puntuacion+"";*/
	}
}
