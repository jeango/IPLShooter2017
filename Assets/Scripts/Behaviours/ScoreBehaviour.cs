using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Behaviours/Score Behaviour")]
public class ScoreBehaviour : ObjectBehaviour {

	public int score;


	public override void Execute (GameObject obj)
	{
		Player player = obj.GetComponent<Player> ();
		if (player) {
			player.AddScore (score);
		}
	}
}

