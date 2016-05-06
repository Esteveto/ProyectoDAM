using UnityEngine;
using System.Collections;
using System.IO;

public class HomeMenu : MonoBehaviour {

    public Texture backgroundTexture;

    public float normalModeButtonX;
    public float normalModeButtonY;

    public float bossModeButtonX;
    public float bossModeByttonY;

    public float RankingButtonX;
    public float RankingButtonY;

    public float ExitButtonX;
    public float ExitButtonY;
    public int ExitButtonWidth;
    public int ExitButtonHeight;

    public int MenuButtonsHeight;
    public int MenuButtonsWidth;

	void Start(){
		if (!System.IO.File.Exists (Application.persistentDataPath +@"/puntuaciones.txt")) {
			TextWriter tw = new StreamWriter(Application.persistentDataPath+@"/puntuaciones.txt", true);
			tw.Write("0;0;0;0;0;");
			tw.Close();
		}
		if(!System.IO.File.Exists (Application.persistentDataPath +@"/infoBosses.txt")) {
			TextWriter tw = new StreamWriter(Application.persistentDataPath+@"/infoBosses.txt", true);
			tw.Write ("false");
			tw.Close ();
		}

	}

    void OnGUI()
    {
        /*/Set Background/*/
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

        /*/Normal mode Button/*/

		if (GUI.Button(new Rect(Screen.width * normalModeButtonX, Screen.height * normalModeButtonY, Screen.width / MenuButtonsWidth, Screen.height / MenuButtonsHeight),"", ""))
        {
            print("Normal mode");
            Application.LoadLevel("NormalMode");
        }

        /*/Boss Mode button/*/
		if (GUI.Button(new Rect(Screen.width * bossModeButtonX, Screen.height * bossModeByttonY, Screen.width / MenuButtonsWidth, Screen.height / MenuButtonsHeight),"", ""))
        {
            print("Boss mode");
            Application.LoadLevel("BossMode");
        }

        /*/Ranking Button/*/
		if (GUI.Button(new Rect(Screen.width * RankingButtonX, Screen.height * RankingButtonY, Screen.width / MenuButtonsWidth, Screen.height / MenuButtonsHeight),"", ""))
        {
            print("Ranking");
            Application.LoadLevel("Ranking");
        }

        /*/Exit Button/*/
		if (GUI.Button(new Rect(Screen.width * ExitButtonX, Screen.height * ExitButtonY,Screen.width /  ExitButtonWidth, Screen.height / ExitButtonHeight),"", ""))
        {
            print("Exit");
            Application.Quit();
        }

		//this.gameObject.GetComponent<RectTransform> ();
    }
}
