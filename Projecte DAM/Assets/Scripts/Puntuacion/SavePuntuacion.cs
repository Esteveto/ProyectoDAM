using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class SavePuntuacion : MonoBehaviour {

	private TextMesh VidasText;
	private int vidas;
	private TextMesh puntuacionText;
	private bool escrito = false;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		VidasText = GameObject.FindGameObjectWithTag ("Vidas").GetComponent<TextMesh>();
		vidas = Convert.ToInt32(VidasText.text);
		puntuacionText = GameObject.FindGameObjectWithTag ("Puntuacion").GetComponent<TextMesh>();
		if (vidas == 0 && escrito == false) {
			/*using (StreamWriter sw = File.AppendText("Puntuaciones.txt")) {
				sw.WriteLine (puntuacionText.text);*/
			writeFile (puntuacionText.text);
			escrito = true;
			}
		}


	public void writeFile(String puntuacion){
		/*TextWriter tw = new StreamWriter(Application.persistentDataPath+@"/puntuaciones.txt", true);
		tw.Write(puntuacion+";");
		tw.Close();*/

		List<String> puntuaciones = readFile ();
		puntuaciones.Sort ();
		//Array.Sort (puntuaciones);
		print(puntuaciones.Count);
		//print(puntuaciones[1]);
		//print (puntuaciones [puntuaciones.Count - 1]);
		int puntMinima = 5000000;
		int posMinima = 0;
		for (int i = 1; i < puntuaciones.Count; i++) {
			print (puntuaciones [i]);
			if (Convert.ToInt32 (puntuaciones[i]) < puntMinima) {
				puntMinima = Convert.ToInt32 (puntuaciones[i]);
				posMinima = i;
			}
		}
		print(puntMinima);

		if (Convert.ToInt32 (puntuacion) > puntMinima) {
			puntuaciones.Add (puntuacion);
			puntuaciones.Sort ();
			//Array.Sort (puntuaciones);
			if (posMinima != 0) {
				puntuaciones.Remove (puntuaciones [posMinima]);
			}
		}

		TextWriter tw = new StreamWriter(Application.persistentDataPath+@"/puntuaciones.txt");
		for (int i = 1; i < puntuaciones.Count; i++) {
			tw.Write(puntuaciones[i]+";");
		}
		tw.Close();

	}

	public List<String> readFile(){
		print (Application.persistentDataPath + @"/puntuaciones.txt");
		TextReader td = new StreamReader (Application.persistentDataPath + @"/puntuaciones.txt");
		String line = td.ReadLine ();
		td.Close();


		return line.Split (';').ToList();
	}
}
