using UnityEngine;
using System.Collections;
using System.Threading;

public class Bala : MonoBehaviour {

	public float velocidadBala;
	private Rigidbody2D myBala;
	private SpriteRenderer explosionRender;
	private GameObject explosion;
	private Animator animExplosion;

	// Use this for initialization
	void Start () {
		myBala = GetComponent<Rigidbody2D> ();
		myBala.velocity = this.transform.up * velocidadBala;
		animExplosion = this.GetComponent<Animator> ();
	}

	//Metodo para detectar las colisiones con los distintos elementos y ejecutar la animacion de la explosion
	void OnCollisionEnter2D (Collision2D col){

		if (col.gameObject.tag != "Player") {
			animExplosion.SetFloat ("explosion", 1f);
		} else {
			animExplosion.SetFloat ("explosion", 1f);
			//Destroy (col.gameObject);
		}
	}
	//Se comprueba que la animacion de la explosion ha sido realizada y si es asi se destruye la bala.
	void Update(){
		if (animExplosion.GetCurrentAnimatorStateInfo (0).IsName ("ExplosionBala") == true) {
			//Thread.Sleep (75);
			Destroy (this.gameObject);
		}
	}
}
