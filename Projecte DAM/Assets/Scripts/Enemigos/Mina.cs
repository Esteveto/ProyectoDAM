using UnityEngine;
using System.Collections;

public class Mina : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo (0).IsName ("DestruccionEnemigo") == true) {
			StartCoroutine (KillOnAnimationEnd());
		}
	}

	private IEnumerator KillOnAnimationEnd() {
		yield return new WaitForSeconds (0.167f);
		Destroy (gameObject);
	}
}
