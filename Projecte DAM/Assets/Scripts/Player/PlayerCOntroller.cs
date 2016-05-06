using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using System;

public class PlayerCOntroller : MonoBehaviour {

	public float moveForce = 5;
	public int fuerzaAvance = 10;
	private Rigidbody2D myBody;
	private Animator anim;
	private Vector2 actualPos;
	private Vector2 avancePos=new Vector2(0f,0f);
	private int limitadorboton = 0;
	private int limitadorboton2 = 0;
	private TextMesh vidasText;
	private int vidas;
	private TextMesh puntuacionTextMesh;
	private string puntuacionString;

	// Use this for initialization
	void Start () {
		myBody=this.GetComponent<Rigidbody2D>();
		anim = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 1) {
			Movimiento ();
			Muerte ();
			//Acciones ();
		}
	}

	void Movimiento(){
		/*/Movimiento del jugador según la direccion del joystick/*/
		Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))*moveForce;
		actualPos= myBody.position;
		/*/Actualizamos la posicion sumando a la actual la direccion del joystic(moveVec)/*/
		myBody.MovePosition (actualPos+moveVec);
		//print(CrossPlatformInputManager.GetAxis("Horizontal"));

		/*/Modificar la rotacion del jugador cuando se mueve/*/
		float heading = Mathf.Atan2(CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"));
		Vector2 quieto = new Vector2 (0f, 0f);
		/*/Solo cuando se mueve/*/
		if (moveVec != quieto) {
			myBody.transform.rotation = Quaternion.Euler (0f, 0f, -heading * Mathf.Rad2Deg);
			anim.SetFloat ("Movement", 1f);
		} else {
			anim.SetFloat ("Movement", 0f);
		}
	}

	void Muerte(){
		vidasText = GameObject.FindGameObjectWithTag ("Vidas").GetComponent<TextMesh>();
		vidas = Convert.ToInt32(vidasText.text);
		if (vidas == 0) {
			Destroy (this.gameObject);
			puntuacionTextMesh = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
			puntuacionString = puntuacionTextMesh.text;
			InfoPuntuacion info = new InfoPuntuacion ();
			info.setPuntuacion(Convert.ToInt32(puntuacionString));
			Application.LoadLevel ("FinalPartida");
		}
	}

	/*/Acciones para la mobilidad del personaje al pulsar los botones/*/
	void Acciones(){
		bool attacking = CrossPlatformInputManager.GetButtonDown ("Attack");
		bool shooting = CrossPlatformInputManager.GetButtonDown ("Shot");
		Vector2 quieto = new Vector2 (0f,0f);
		if(new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))!=quieto){
			avancePos = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))*fuerzaAvance;
		}

		if ((attacking)&&limitadorboton==0) {
			myBody.MovePosition (actualPos+avancePos);
			//print ("Attack");
			limitadorboton = 40;
		}else if ((shooting)&&limitadorboton2==0) {
			myBody.MovePosition (actualPos-avancePos);
			limitadorboton2 = 40;
			//print ("Shot");
		}

		/*/Reducimos el limitador hasta llegar a 0/*/
		if (limitadorboton > 0) {
			limitadorboton--;
		} else if (limitadorboton2 > 0) {
			limitadorboton2--;
		}
	}
}
