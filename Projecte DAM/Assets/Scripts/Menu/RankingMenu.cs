using UnityEngine;
using System.Collections;

public class RankingMenu : MonoBehaviour {

    public Texture backgroundTexture;

    public float BackButtonX;
    public float BackButtonY;
    public int BackButtonWidth;
    public int BackButtonHeight;


    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

        if (GUI.Button(new Rect(Screen.width * BackButtonX, Screen.height * BackButtonY, BackButtonWidth, BackButtonHeight), "", ""))
        {
            print("Atras");
            Application.LoadLevel("Home");
        }
    }
}
