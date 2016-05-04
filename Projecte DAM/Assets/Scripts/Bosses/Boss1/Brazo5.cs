using UnityEngine;
using System.Collections;

public class Brazo5 : MonoBehaviour {

	private BoxCollider2D colliderTorreta;
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
		colliderTorreta = InfoBoss1.getColliderTorreta ();
		colliderTorreta.enabled = true;	

		/*puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		puntuacion = Convert.ToInt32(puntuacionText.text);
		puntuacion = puntuacion + 10;
		puntuacionText.text = puntuacion+"";*/
	}
}
