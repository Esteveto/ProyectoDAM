using UnityEngine;
using System.Collections;
using System;


public class BalaJugador : MonoBehaviour {

	public float velocidadBala;
	private Rigidbody2D myBala;
	private SpriteRenderer explosionRender;
	private GameObject explosion;
	private Animator animExplosion;
	private Animator explosionEnemigo;
	private TextMesh puntuacionText;
	private int puntuacion;

	// Use this for initialization
	void Start () {
		myBala = GetComponent<Rigidbody2D> ();
		myBala.velocity = this.transform.up * velocidadBala;
		animExplosion = this.GetComponent<Animator> ();
	}

	//Metodo para detectar la collision con la pared y ejecutar la animacion de la explosion
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Enemigo") {
			//print("Enemigo");
			animExplosion.SetFloat ("explosion", 1f);
			col.gameObject.GetComponent<Animator> ().SetFloat ("Explosion", 1f);
			//Destroy (col.gameObject);
		} else if (col.gameObject.tag == "Player") {
		} else if (col.gameObject.tag == "Pared" ) {
			animExplosion.SetFloat ("explosion", 1f);
			/*puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
			puntuacion = Convert.ToInt32(puntuacionText.text);
			puntuacion = puntuacion - 1;
			puntuacionText.text = puntuacion+"";*/
		} else {
			//print ("Pared");
			animExplosion.SetFloat ("explosion", 1f);
			//Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Boss1") {
			animExplosion.SetFloat ("explosion", 1f);
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
