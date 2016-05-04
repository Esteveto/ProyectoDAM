using UnityEngine;
using System.Collections;

public class Brazo3 : MonoBehaviour {

	private GameObject disparoBrazo4;
	private PolygonCollider2D collider4;
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
		Instantiate (torretaSpawn,gameObject.transform.position,gameObject.transform.rotation);
		Destroy (gameObject);
		disparoBrazo4 = InfoBoss1.getDisparo4();
		collider4 = InfoBoss1.getCollider4 ();
		disparoBrazo4.SetActive (true);
		collider4.enabled = true;
		/*puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		puntuacion = Convert.ToInt32(puntuacionText.text);
		puntuacion = puntuacion + 10;
		puntuacionText.text = puntuacion+"";*/
	}
}
