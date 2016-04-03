using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class CuerpoACuerpo : MonoBehaviour {

	/*/Declaracion variables/*/
	public int fuerzaAvance = 10;
	Rigidbody2D myBody;
	Animator anim;
	int limitadorBoton = 0;
	GameObject player;
	Rigidbody2D rigidPlayer;
	Vector2 actualPos;
	Vector2 avancePos = new Vector2(0f,0f);
	Vector2 quieto = new Vector2 (0f,0f);
	BoxCollider2D boxCollider;

	// Use this for initialization
	void Start () {
		myBody=this.GetComponent<Rigidbody2D>();
		anim = this.GetComponent<Animator> ();
		player = GameObject.Find("Personaje principal(Quieto)");
		rigidPlayer = player.GetComponent<Rigidbody2D>();
		boxCollider = this.GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Acciones ();
		Ataque ();
	}
	/*/Metodo para las acciones/*/
	void Acciones(){

		if(new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))!=quieto){
			avancePos = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))*fuerzaAvance;	
		}
		
		/*/comprobamos que se pulsa el boton/*/
		bool attacking = CrossPlatformInputManager.GetButtonDown ("Attack");
		/*/Si se pulsa el boton y el limitador esta a 0 ralizar la animacion modificando el parametro que ejecuta la animacion(Ataque)/*/
		if ((attacking||Input.GetKey(KeyCode.Q)) && (limitadorBoton==0)) {
			//print ("Attack");
			rigidPlayer.MovePosition (rigidPlayer.position + avancePos);

			anim.SetFloat ("Ataque", 1f);
			//print (anim.GetFloat ("Ataque"));

			//print (rigidPlayer);
			limitadorBoton = 40;
		} else {
			/*/Modificamos el parametro a 0 para que no se ejecute la animacion cuando no se pulsa nada y el boton esta limitado/*/
			//print (limitadorBoton);
			anim.SetFloat ("Ataque", 0f);
		}
		/*/Reducimos el limitador hasta llegar a 0/*/
		if (limitadorBoton > 0) {
			limitadorBoton--;
		}
	}
	void Ataque (){
		if (gameObject.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Ataque") == true) {
			boxCollider.enabled = true;
		} else {
			boxCollider.enabled = false;
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Enemigo") {
			col.gameObject.GetComponent<Animator> ().SetFloat ("Explosion", 1f);
			//Destroy (col.gameObject);
		}
				
		}
	}
	
