using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class RankingMenu : MonoBehaviour {

    public Texture backgroundTexture;
	public Font Font;
    public float BackButtonX;
    public float BackButtonY;
    public int BackButtonWidth;
    public int BackButtonHeight;
	public float Puntuaciones1X;
	public float Puntuaciones1Y;
	public float Puntuaciones2X;
	public float Puntuaciones2Y;
	public float Puntuaciones3X;
	public float Puntuaciones3Y;
	public float Puntuaciones4X;
	public float Puntuaciones4Y;
	public float Puntuaciones5X;
	public float Puntuaciones5Y;
	public int PuntuacionesWidth;
	public int PuntuacionesHeight;

	private String puntuacion1S;
	private String puntuacion2S;
	private String puntuacion3S;
	private String puntuacion4S;
	private String puntuacion5S;

	int[] puntuaciones;

	private bool leido = false;
	private GUIStyle stylePuntuacion;

	void Start(){
		stylePuntuacion = new GUIStyle ();
		stylePuntuacion.font = Font;
		stylePuntuacion.alignment = TextAnchor.MiddleCenter;

	}

	void setPuntuaciones(){
		if (leido == false) {
			//string[] lines = System.IO.File.ReadAllLines ("Puntuaciones.txt");
			string[] lines = readFile();
			puntuaciones = new int[lines.Length];
			Array.Sort (lines);
			for (int i = 1; i < lines.Length; i++) {
				puntuaciones [i] = Int32.Parse(lines [i]);
			}
			leido = true;
			Array.Sort (puntuaciones);
			for (int i = 0; i < puntuaciones.Length; i++) {
				print (puntuaciones [i]);
			}
		}

		puntuacion1S = puntuaciones[puntuaciones.Length-1] + "";
		puntuacion2S = puntuaciones[puntuaciones.Length-2] + "";
		puntuacion3S = puntuaciones[puntuaciones.Length-3] + "";
		puntuacion4S = puntuaciones[puntuaciones.Length-4] + "";
		puntuacion5S = puntuaciones [puntuaciones.Length - 5] + "";
	}

	string[] readFile(){
		print (Application.persistentDataPath + @"/puntuaciones.txt");
		TextReader td = new StreamReader (Application.persistentDataPath + @"/puntuaciones.txt");
		String line = td.ReadLine ();
		td.Close();

		/*if (line.Split (';').Length < 5) {
			TextWriter tw = new StreamWriter(Application.persistentDataPath+@"/puntuaciones.txt", true);
			tw.Write("0;0;0;0;0;");
			tw.Close();
		}*/
		return line.Split(';');
	}


    void OnGUI()
    {
		setPuntuaciones();
		stylePuntuacion.fontSize = Screen.height / 10;

        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

		GUI.TextArea(new Rect(Screen.width * Puntuaciones1X, Screen.height * Puntuaciones1Y,Screen.width /  PuntuacionesWidth,Screen.height /  PuntuacionesHeight),puntuacion1S, stylePuntuacion);
		GUI.TextArea(new Rect(Screen.width * Puntuaciones2X, Screen.height * Puntuaciones2Y,Screen.width /  PuntuacionesWidth,Screen.height /  PuntuacionesHeight),puntuacion2S, stylePuntuacion);
		GUI.TextArea(new Rect(Screen.width * Puntuaciones3X, Screen.height * Puntuaciones3Y,Screen.width /  PuntuacionesWidth,Screen.height /  PuntuacionesHeight),puntuacion3S, stylePuntuacion);
		GUI.TextArea(new Rect(Screen.width * Puntuaciones4X, Screen.height * Puntuaciones4Y,Screen.width /  PuntuacionesWidth,Screen.height /  PuntuacionesHeight),puntuacion4S, stylePuntuacion);
		GUI.TextArea(new Rect(Screen.width * Puntuaciones5X, Screen.height * Puntuaciones5Y,Screen.width /  PuntuacionesWidth,Screen.height /  PuntuacionesHeight),puntuacion5S, stylePuntuacion);

		if (GUI.Button(new Rect(Screen.width * BackButtonX, Screen.height * BackButtonY,Screen.width /  BackButtonWidth,Screen.height /  BackButtonHeight),"", ""))
        {
            print("Atras");
            Application.LoadLevel("Home");
        }
    }
}
