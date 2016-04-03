using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool paused;

	// Use this for initialization
	void Start () {
		paused = false;
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnApplicationPause (bool pauseStatus){
		paused = pauseStatus;
	}

	public void PauseTime(){

		paused = !paused;

		if (paused) {
			//OnPauseGame ();
			Time.timeScale = 0.0f;
		} else if (!paused) {
			Time.timeScale = 1.0f;
		}

	}
}
