using UnityEngine;
using System.Collections;

public class MovimientoBoss1 : MonoBehaviour {

	private float rotationX, rotationY, rotationZ;
	private float positionX, positionY;
	private int contador;

	// Use this for initialization
	void Start () {
		rotationX = this.transform.rotation.x;
		rotationY = this.transform.rotation.y;
		rotationZ = this.transform.rotation.z;
		positionX = this.transform.position.x;
		positionY = this.transform.position.y;
		contador = 0;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = Quaternion.Euler (rotationX,rotationY,rotationZ++);
		Movimiento();
	}

	void Movimiento(){
		if (contador == 0) {
			float randX = Random.Range (-10f, 10f);
			float randY = Random.Range (-10f, 10f);
			this.transform.position = new Vector3(positionX + randX,positionY + randY,this.transform.position.z);
			contador = 100;
		}
		contador--;
		//this.transform.position.y = positionY + randY;
	}
}
