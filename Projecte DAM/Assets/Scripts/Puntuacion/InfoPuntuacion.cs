using UnityEngine;
using System.Collections;

public class InfoPuntuacion : MonoBehaviour {
	
	public static int puntuacion = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getPuntuacion(){
		return puntuacion;
	}

	public void setPuntuacion(int punt){
		puntuacion = punt;
	}
}
