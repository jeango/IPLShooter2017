using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreValue : MonoBehaviour {

	public int score;

	public void GiveScore(GameObject target) {
		if (target) {
			Player player = target.GetComponent<Player> ();
			if (player) {
				player.AddScore (score);
			}
		}
	}
}

