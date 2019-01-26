using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerActions {

	public static int 	intTrap, maxEventCount, contador = 0;
	public static float timer 				= 0;
	public static bool 	eventCollider 		= true;
	
	public static void ContadorEvento (int tipoTrap) {
		if (Input.GetKeyDown(KeyCode.Space) && intTrap == tipoTrap) {
			contador++;
		}
	}

	public static void TimeCounter () {
		timer += 1 * Time.deltaTime;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
	}
}