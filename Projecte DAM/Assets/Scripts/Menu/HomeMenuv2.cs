using UnityEngine;
using System.Collections;

public class HomeMenuv2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NormalMode(){
		Application.LoadLevel("NormalMode");
	}

	public void BossMode(){
		Application.LoadLevel("BossMode");
	}

	public void Ranking(){
		Application.LoadLevel("Ranking");
	}

	public void ExitApp(){
		Application.Quit();
	}
}
