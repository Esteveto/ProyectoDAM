using UnityEngine;
using System.Collections;

public class Brazo4 : MonoBehaviour {

	private GameObject disparoBrazo5;
	private PolygonCollider2D collider5;
	public GameObject torretaSpawn1;
	public GameObject torretaSpawn2;

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
		Instantiate (torretaSpawn1,gameObject.transform.position,gameObject.transform.rotation);
		Instantiate (torretaSpawn2,gameObject.transform.position,gameObject.transform.rotation);
		Destroy (gameObject);
		disparoBrazo5 = InfoBoss1.getDisparo5();
		collider5 = InfoBoss1.getCollider5 ();
		disparoBrazo5.SetActive (true);
		collider5.enabled = true;
		/*puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		puntuacion = Convert.ToInt32(puntuacionText.text);
		puntuacion = puntuacion + 10;
		puntuacionText.text = puntuacion+"";*/
	}
}
