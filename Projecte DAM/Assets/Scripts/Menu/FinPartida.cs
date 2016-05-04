using UnityEngine;
using System.Collections;

public class FinPartida : MonoBehaviour {
	
	public Texture backgroundTexture;
	public Font Font;
	private GUIStyle stylePuntuacion;
	public float PuntuacionX;
	public float PuntuacionY;
	public int puntuacionWidth;
	public int puntuacionHeight;
	public float homeButtonX;
	public float homeButtonY;
	public float homeButtonWidth;
	public float homeButtonHeight;
	public float playAgainButtonX;
	public float playAgainButtonY;
	public float playAgainButtonWidth;
	public float playAgainButtonHeight;
	private TextMesh puntuacionTextMesh;
	private string puntuacionString;

	// Use this for initialization
	void Start(){
		stylePuntuacion = new GUIStyle ();
		stylePuntuacion.font = Font;
		stylePuntuacion.alignment = TextAnchor.MiddleCenter;
		InfoPuntuacion info = new InfoPuntuacion ();
		/*puntuacionTextMesh = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		puntuacionString = puntuacionTextMesh.text;*/
		puntuacionString = ""+info.getPuntuacion();
		//Destroy (puntuacionTextMesh);
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void OnGUI(){
		stylePuntuacion.fontSize = Screen.height / 10;
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

		GUI.Label(new Rect(Screen.width * PuntuacionX, Screen.height * PuntuacionY,Screen.width /  puntuacionWidth,Screen.height /  puntuacionHeight),puntuacionString, stylePuntuacion);

		if (GUI.Button(new Rect(Screen.width * homeButtonX, Screen.height * homeButtonY,Screen.width /  homeButtonWidth,Screen.height /  homeButtonHeight),"", ""))
		{
			//print("Home");
			Application.LoadLevel("Home");
		}

		if (GUI.Button(new Rect(Screen.width * playAgainButtonX, Screen.height * playAgainButtonY,Screen.width /  playAgainButtonWidth,Screen.height /  playAgainButtonHeight),"", ""))
		{
			//print("PlayAgain");
			Application.LoadLevel("NormalMode");
		}
	}
}
