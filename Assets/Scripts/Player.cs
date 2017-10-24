using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using My.Events;

// Note: on peut parfaitement mettre la gestion du score
// dans un autre objet (ScoreManager par exemple) et référencer
// cet objet dans notre player.
public class Player : MonoBehaviour {

	public int score = 0;

	// ne pas oublier "using My.Events" 
	public IntEvent OnScoreChange;

	void OnEnable() {
		score = 0;
		OnScoreChange.Invoke (score);
	}

	public void AddScore(int score) {
		this.score += score;
		OnScoreChange.Invoke (this.score);
	}
}
