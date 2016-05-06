using UnityEngine;
using System.Collections;
using System;

public class NormalMode : MonoBehaviour {

	private GameObject boss1;
	private GameObject boss1Disparo1;
	private GameObject boss1Disparo2;
	private GameObject boss1Disparo3;
	private GameObject boss1Disparo4;
	private GameObject boss1Disparo5;
	private GameObject boss1Torreta;
	private PolygonCollider2D brazo1col;
	private PolygonCollider2D brazo2col;
	private PolygonCollider2D brazo3col;
	private PolygonCollider2D brazo4col;
	private PolygonCollider2D brazo5col;
	private BoxCollider2D torretaCol;
	private bool boss1Activado;
	private GameObject generadorEnemigos;

	private TextMesh puntuacionText;
	private int puntuacion;
	// Use this for initialization
	void Start () {
		
		boss1 = GameObject.FindGameObjectWithTag ("Boss1");
		boss1Disparo1 = GameObject.FindGameObjectWithTag ("Boss1Disparo1");
		boss1Disparo2 = GameObject.FindGameObjectWithTag ("Boss1Disparo2");
		boss1Disparo3 = GameObject.FindGameObjectWithTag ("Boss1Disparo3");
		boss1Disparo4 = GameObject.FindGameObjectWithTag ("Boss1Disparo4");
		boss1Disparo5 = GameObject.FindGameObjectWithTag ("Boss1Disparo5");
		boss1Torreta = GameObject.FindGameObjectWithTag ("Boss1Torreta");
		brazo1col = GameObject.FindGameObjectWithTag ("Boss1Brazo1").GetComponent<PolygonCollider2D> ();
		brazo2col = GameObject.FindGameObjectWithTag ("Boss1Brazo2").GetComponent<PolygonCollider2D> ();
		brazo3col = GameObject.FindGameObjectWithTag ("Boss1Brazo3").GetComponent<PolygonCollider2D> ();
		brazo4col = GameObject.FindGameObjectWithTag ("Boss1Brazo4").GetComponent<PolygonCollider2D> ();
		brazo5col = GameObject.FindGameObjectWithTag ("Boss1Brazo5").GetComponent<PolygonCollider2D> ();
		torretaCol = boss1Torreta.GetComponent<BoxCollider2D> ();
		boss1Activado = false;
		generadorEnemigos = GameObject.FindGameObjectWithTag ("GeneradorEnemigos");

		//print (boss1Disparo2);

		InfoBoss1.setBoss1 (boss1);
		InfoBoss1.setDisparo1 (boss1Disparo1);
		InfoBoss1.setDisparo2 (boss1Disparo2);
		InfoBoss1.setDisparo3 (boss1Disparo3);
		InfoBoss1.setDisparo4 (boss1Disparo4);
		InfoBoss1.setDisparo5 (boss1Disparo5);
		InfoBoss1.setTorreta (boss1Torreta);
		InfoBoss1.setCollider1 (brazo1col);
		InfoBoss1.setCollider2 (brazo2col);
		InfoBoss1.setCollider3 (brazo3col);
		InfoBoss1.setCollider4 (brazo4col);
		InfoBoss1.setCollider5 (brazo5col);
		InfoBoss1.setTorretaCollider (torretaCol);

		boss1.SetActive (false);

		boss1Disparo1.SetActive (false);
		boss1Disparo2.SetActive (false);
		boss1Disparo3.SetActive (false);
		boss1Disparo4.SetActive (false);
		boss1Disparo5.SetActive (false);

		brazo2col.enabled = false;
		brazo3col.enabled = false;
		brazo4col.enabled = false;
		brazo5col.enabled = false;

		torretaCol.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		puntuacion = Convert.ToInt32(puntuacionText.text);
		if (puntuacion >= 50 && boss1Activado == false) {
			generadorEnemigos.GetComponent<GeneradorEnemigos> ().activo = false;
			boss1.SetActive (true);
			boss1Disparo1.SetActive (true);
			boss1Activado = true;
		}
	}
}
