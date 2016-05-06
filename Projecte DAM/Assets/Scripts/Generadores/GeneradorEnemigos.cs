using UnityEngine;
using System.Collections;

public class GeneradorEnemigos : MonoBehaviour {

	public GameObject[] enemigos;
	public float tiempoMin = 1f;
	public float tiempoMax = 2f;
	public bool activo = true;
	public bool activo2 = true;

	// Use this for initialization
	void Start () {
			//Generar ();
	}
	
	// Update is called once per frame
	void Update () {
		if (activo && activo2) {
			Generar ();
		}
	}

	void Generar(){
		if (activo) {
			activo2 = false;
			float randX = Random.Range (-80f, 75f);
			float randY = Random.Range (-25f, 30f);
			float randRotationZ = Random.Range (0f, 360f);

			Vector3 randomPosition = new Vector3 (randX, randY, -5.5f);

			Instantiate (enemigos [Random.Range (0, enemigos.Length)], randomPosition, Quaternion.Euler (0f, 0f, randRotationZ));
			Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
		}
	}
}
