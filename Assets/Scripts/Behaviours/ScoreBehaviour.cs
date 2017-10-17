using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName="Behaviours/ScoreBehaviour")]
public class ScoreBehaviour : ObjectBehaviour {

	public int score;

	public override void Execute (GameObject ob)
	{
		score++;
	}
}
