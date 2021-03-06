﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using My.Events;

public class Player : MonoBehaviour {

	public int score;

	public IntEvent OnScoreChange;

	public void SetScore(int newScore) {
		score = newScore;
		OnScoreChange.Invoke (score);
	}

	void OnEnable() {
		SetScore (0);
	}

	public void AddScore (int additionalScore) {
		SetScore (score + additionalScore);
	}

}