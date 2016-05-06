using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using System.Threading;

public abstract class Disparo : MonoBehaviour {

	int limitadorboton=0;
	//SpriteRenderer renderer;

	// Use this for initialization
	void Start () {
		//renderer = this.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 1) {
			Acciones ();
			retroceso ();
		}
	}
	//MEtodo que se encarga de llamar a los metodos de disparar, retroceso y sprite render cuando se pulsan los botones.
	//el boton tiene un limitador para que no se pueda pulsar simpre que se quiera.
	void Acciones(){

		bool shooting = CrossPlatformInputManager.GetButtonDown ("Shot");

		if ((shooting||Input.GetKey(KeyCode.E))&&(limitadorboton==0)) {
			//print ("Shot");
			limitadorboton = 40;
			//renderer.enabled = true;
			spriteRender ().enabled = true;
			Shoot ();
		} 
		if (limitadorboton > 0) {
			limitadorboton--;
		}
		if (limitadorboton == 30) {
			//renderer.enabled = false;
			spriteRender().enabled = false;
		}
	}

	protected abstract void Shoot ();
	protected abstract SpriteRenderer spriteRender();
	protected abstract void retroceso();
}
