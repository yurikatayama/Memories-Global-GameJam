using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerActions {

	public static bool 	boolPombos 			= false;
	public static bool 	boolCachorros 		= false;
	public static bool 	boolMendigo			= false;
	public static bool 	boolCasal			= false;
	public static bool 	Hidrante			= false;
	public static bool	boolCamelo			= false;

	public static float timer 				= 0;
	public static int 	contador 			= 0;
	public static bool 	eventCollider 		= true;

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
		if (Input.GetKeyDown(KeyCode.Space) && boolPombos) {
			contador++;
		}
	}

	public static void TimeCounter () {
		timer += 1 * Time.deltaTime;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
	}
}