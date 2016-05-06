using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class BossMenu : MonoBehaviour
{

    public Texture backgroundTexture;
	public Texture backgroundTextureBoss1;

    public float BackButtonX;
    public float BackButtonY;
    public int BackButtonWidth;
    public int BackButtonHeight;

    public float Boss1ButtonX;
    public float Boss1ButtonY;
    public float Boss1ButtonWidth;
	public float Boss1ButtonHeight;

	private string line;

	void Start(){
		readFile();
	}

    void OnGUI()
    {
		if (line == "false") {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		} else {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTextureBoss1);

			if (GUI.Button (new Rect (Screen.width * Boss1ButtonX, Screen.height * Boss1ButtonY, Screen.width / Boss1ButtonWidth, Screen.height / Boss1ButtonHeight),"", "")) {
				print ("Boss1");
				//Application.LoadLevel("BossMode");
			}
		}
        

		if (GUI.Button(new Rect(Screen.width * BackButtonX, Screen.height * BackButtonY,Screen.width /  BackButtonWidth,Screen.height /  BackButtonHeight),"",""))
        {
            print("Atras");
            Application.LoadLevel("Home");
        }

    }

	void readFile(){
		TextReader td = new StreamReader (Application.persistentDataPath + @"/infoBosses.txt");
		line = td.ReadLine ();
		td.Close();
	}
}