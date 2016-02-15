using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	public float velocidadCamara;
	public float separacion;
	private Transform player;
	private Vector3 targetPosition;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		separacion = 10;
	}
	
	// Update is called once per frame
	//Metodo para que la camara siga al jugador
	void Update () {
		if (player != null) {
			targetPosition = player.position +Vector3.back * separacion;
			this.transform.position = Vector3.Lerp (this.transform.position, targetPosition, Time.deltaTime*velocidadCamara);
		}
	}
}
