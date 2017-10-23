using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Note: on peut parfaitement mettre la gestion du score
// dans un autre objet (ScoreManager par exemple) et référencer
// cet objet dans notre player.
public class Player : MonoBehaviour {

	public int score = 0;

	public void AddScore(int score) {
		this.score += score;
	}
}
