using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerActions {

	public static bool 	boolTrap 			= false;
	public static bool	gameOverCond		= false;
	public static float	timer 				= 20;
	public static int 	contador 			= 0;
	public static int	maxEventCount		= Random.Range(12,30);

	public static void ContadorEvento () {
		if (Input.GetKeyDown(KeyCode.Space) && boolTrap) contador++;
	}

	public static void TimeCounter () {
		timer -= 1 * Time.deltaTime;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
	}
}