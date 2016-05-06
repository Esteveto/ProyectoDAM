using UnityEngine;
using System.Collections;

public class SpawnBalaTorreta : MonoBehaviour {

	public GameObject Bala;
	public Transform spawnBala;
	public int frecuenciaDiparo = 40;
	private SpriteRenderer spriteDisparo;
	private int contador=0;

	// Use this for initialization
	void Start () {
		spriteDisparo = this.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 1) {
			DisparoBala ();
		}

	}

	//Metodo que hace que la torreta dispare
	void DisparoBala(){
		
		if(contador==0){
			Instantiate (Bala, spawnBala.position, spawnBala.rotation);
			contador = frecuenciaDiparo;
			spriteDisparo.enabled = true;

		}
		if (contador > 0) {
			contador--;
		}
		if (contador == frecuenciaDiparo-10) {
			spriteDisparo.enabled = false;
		}


	}
}
