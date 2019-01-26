using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerActions {

	public static bool alimentarPombos = false;
	public static bool oculos = false;
	public static bool chave = false;
	public static float timer = 0;
	public static int contador = 0;
	public static bool eventCollider = true;

	/*
	public static bool 
	public static bool 
	public static bool 
	public static bool 
	public static bool 
	public static bool 
	public static bool 
	public static bool 
	*/

	public static void ContarPombos () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			contador++;
		}
	}

	public static void TimeCounter () {
		timer += 1 * Time.deltaTime;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
	}
}
