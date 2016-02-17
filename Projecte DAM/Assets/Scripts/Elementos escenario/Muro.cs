using UnityEngine;
using System.Collections;

public class Muro : MonoBehaviour {

	public Sprite MuroDeteriorado1;
	public Sprite MuroDeteriorado2;
	private int hits;
	private SpriteRenderer SpriteMuro;
	private Animator animDestruccion;

	// Use this for initialization
	void Start () {
		SpriteMuro = this.GetComponent<SpriteRenderer> ();
		animDestruccion = this.GetComponent<Animator> ();
		hits = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo (0).IsName ("DestruccionMuro") == true) {
			StartCoroutine (KillOnAnimationEnd());
		}
	}

	void OnCollisionEnter2D (Collision2D col){
		
		if ((col.gameObject.tag == "Bala") && (hits == 0)) {
			print ("Impacto");
			print (hits);
			SpriteMuro.sprite = MuroDeteriorado1;
			hits++;
		} else if ((col.gameObject.tag == "Bala") && (hits == 1)) {
			SpriteMuro.sprite = MuroDeteriorado2;
			hits++;
		} else if (hits == 2) {
			print (hits);
			animDestruccion.enabled = true;	
			animDestruccion.SetFloat ("Destruccion", 1f);
			//DEstruir objeto
		}

	}

	private IEnumerator KillOnAnimationEnd() {
		yield return new WaitForSeconds (0.167f);
		Destroy (gameObject);
	}
}
