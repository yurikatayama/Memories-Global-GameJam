using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreActions {

	public static int contador = 0;

	public static void ContadorEvento () {
		contador++;
	}

    public static void ResetaContador () {
        contador = 0;
    }
}