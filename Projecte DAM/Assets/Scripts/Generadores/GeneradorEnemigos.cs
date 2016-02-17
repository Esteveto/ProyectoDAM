using UnityEngine;
using System.Collections;

public class GeneradorEnemigos : MonoBehaviour {

	public GameObject[] enemigos;
	public float tiempoMin = 1f;
	public float tiempoMax = 2f;

	// Use this for initialization
	void Start () {
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Generar(){
		float randX = Random.Range (-90f, 85f);
		float randY = Random.Range (-30f, 35f);

		Vector3 randomPosition = new Vector3 (randX,randY,-5.5f);

		Instantiate (enemigos [Random.Range (0, enemigos.Length)], randomPosition, Quaternion.identity);
		Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
	}
}
