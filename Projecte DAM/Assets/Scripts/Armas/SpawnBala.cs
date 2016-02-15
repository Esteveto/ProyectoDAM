using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class SpawnBala : Disparo {

	public GameObject Bala;
	public Transform spawnBala;
	public int fuerzaAvance = 10;
	SpriteRenderer spriteDisparo;
	GameObject player;
	Rigidbody2D rigidPlayer;
	Vector2 avancePos;

	// Use this for initialization
	void Start () {
		spriteDisparo = this.GetComponent<SpriteRenderer> ();
		player = GameObject.Find("Personaje principal(Quieto)");
		rigidPlayer = player.GetComponent<Rigidbody2D>();
	}
	//Metodo para tealizar el retroceso del personaje
	protected override void retroceso(){
		Vector2 quieto = new Vector2 (0f,0f);
		if(new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))!=quieto){
			avancePos = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))*fuerzaAvance;
		}
	}
 	//Metodopara inicializar la bala, para que se cree el objecto
	protected override void Shoot ()
	{
		Instantiate (Bala, spawnBala.position, spawnBala.rotation);

		rigidPlayer.MovePosition (rigidPlayer.position - avancePos);
	}
	//metodo que devuelve la renderizacion del sprite del disparo
	protected override SpriteRenderer spriteRender ()
	{
		return spriteDisparo;
	}
}
