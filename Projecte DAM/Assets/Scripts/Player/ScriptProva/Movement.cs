using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float velocidad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MovementController ();
	}

	void MovementController(){
		if(Input.GetKey(KeyCode.W)){
			print ("Tecla W");
			transform.position = new Vector3 (transform.position.x, transform.position.y + velocidad * Time.deltaTime, transform.position.z);
			transform.rotation = Quaternion.identity;
		}else if(Input.GetKey(KeyCode.S)){
			print ("Tecla S");
			transform.position = new Vector3 (transform.position.x, transform.position.y - velocidad * Time.deltaTime, transform.position.z);
			transform.rotation = Quaternion.Euler (0, 0, 180);
		}else if(Input.GetKey(KeyCode.A)){
			print ("Tecla A");
			transform.position = new Vector3 (transform.position.x - velocidad * Time.deltaTime, transform.position.y, transform.position.z);
			transform.rotation = Quaternion.Euler (0, 0, 90);
		}else if(Input.GetKey(KeyCode.D)){
			print ("Tecla D");
			transform.position = new Vector3 (transform.position.x + velocidad * Time.deltaTime, transform.position.y, transform.position.z);
			transform.rotation = Quaternion.Euler (0, 0, 270);
		}
	}
}
