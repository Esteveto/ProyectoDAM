using UnityEngine;
using System.Collections;

public class InfoBoss1 : MonoBehaviour {

	public static GameObject boss1;
	public static GameObject boss1Disparo1;
	public static GameObject boss1Disparo2;
	public static GameObject boss1Disparo3;
	public static GameObject boss1Disparo4;
	public static GameObject boss1Disparo5;
	public static GameObject boss1Torreta;
	public static PolygonCollider2D brazo1col;
	public static PolygonCollider2D brazo2col;
	public static PolygonCollider2D brazo3col;
	public static PolygonCollider2D brazo4col;
	public static PolygonCollider2D brazo5col;
	public static BoxCollider2D torretaCol;
	public static bool eliminado = false;

	public static void setBoss1(GameObject boss){
		boss1 = boss;
	}

	public static void setDisparo1(GameObject dis1){
		boss1Disparo1 = dis1;
	}

	public static void setDisparo2(GameObject dis2){
		boss1Disparo2 = dis2;
	}

	public static void setDisparo3(GameObject dis3){
		boss1Disparo3 = dis3;
	}

	public static void setDisparo4(GameObject dis4){
		boss1Disparo4 = dis4;
	}

	public static void setDisparo5(GameObject dis5){
		boss1Disparo5 = dis5;
	}

	public static void setTorreta(GameObject torreta){
		boss1Torreta = torreta;
	}

	public static void setCollider1(PolygonCollider2D col1){
		brazo1col = col1;
	}

	public static void setCollider2(PolygonCollider2D col2){
		brazo2col = col2;
	}

	public static void setCollider3(PolygonCollider2D col3){
		brazo3col = col3;
	}

	public static void setCollider4(PolygonCollider2D col4){
		brazo4col = col4;
	}

	public static void setCollider5(PolygonCollider2D col5){
		brazo5col = col5;
	}

	public static void setTorretaCollider(BoxCollider2D col){
		torretaCol = col;
	}

	public static void setEliminado (bool el){
		eliminado = el;
	}

	public static GameObject getBoss1(){
		return boss1;
	}

	public static GameObject getDisparo1(){
		return boss1Disparo1;
	}

	public static GameObject getDisparo2(){
		return boss1Disparo2;
	}
	public static GameObject getDisparo3(){
		return boss1Disparo3;
	}
	public static GameObject getDisparo4(){
		return boss1Disparo4;
	}
	public static GameObject getDisparo5(){
		return boss1Disparo5;
	}
		
	public static PolygonCollider2D getCollider1(){
		return brazo1col;
	}

	public static PolygonCollider2D getCollider2(){
		return brazo2col;
	}

	public static PolygonCollider2D getCollider3(){
		return brazo3col;
	}

	public static PolygonCollider2D getCollider4(){
		return brazo4col;
	}

	public static PolygonCollider2D getCollider5(){
		return brazo5col;
	}

	public static BoxCollider2D getColliderTorreta(){
		return torretaCol;
	}

	public static bool getEliminado(){
		return eliminado;
	}

}
