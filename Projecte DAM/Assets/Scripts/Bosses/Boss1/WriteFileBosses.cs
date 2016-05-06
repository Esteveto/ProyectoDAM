using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class WriteFileBosses : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (InfoBoss1.getEliminado ()) {
			saveInfoBoss1 ();
		}
	}

	private void saveInfoBoss1(){
		//print (Application.persistentDataPath + @"/puntuaciones.txt");
		TextReader td = new StreamReader (Application.persistentDataPath + @"/infoBosses.txt");
		String line = td.ReadLine ();
		td.Close();

		if (line == "false") {
			TextWriter tw = new StreamWriter(Application.persistentDataPath+@"/infoBosses.txt", false);
			tw.Write ("true");
			tw.Close ();
		}
	}


}
