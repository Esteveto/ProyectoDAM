using UnityEngine;
using System.Collections;

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

    void OnGUI()
    {
        /*/Set Background/*/
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

        /*/Normal mode Button/*/
        if (GUI.Button(new Rect(Screen.width * normalModeButtonX, Screen.height * normalModeButtonY, MenuButtonsWidth, MenuButtonsHeight),"", ""))
        {
            print("Normal mode");
            Application.LoadLevel("NormalMode");
        }

        /*/Boss Mode button/*/
        if (GUI.Button(new Rect(Screen.width * bossModeButtonX, Screen.height * bossModeByttonY, MenuButtonsWidth, MenuButtonsHeight),"",  ""))
        {
            print("Boss mode");
            Application.LoadLevel("BossMode");
        }

        /*/Ranking Button/*/
        if (GUI.Button(new Rect(Screen.width * RankingButtonX, Screen.height * RankingButtonY, MenuButtonsWidth, MenuButtonsHeight),"", ""))
        {
            print("Ranking");
            Application.LoadLevel("Ranking");
        }

        /*/Exit Button/*/
        if (GUI.Button(new Rect(Screen.width * ExitButtonX, Screen.height * ExitButtonY, ExitButtonWidth, ExitButtonHeight),"", ""))
        {
            print("Exit");
            Application.Quit();
        }
    }
}
