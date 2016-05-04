using UnityEngine;
using System.Collections;

public class DontDestroyPuntuacion : MonoBehaviour {

	private TextMesh puntuacionTextMesh;
	public string puntuacionString;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
