using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public string newGameSceneName;
	public string mainMenuSceneName;
	public string gameOverSceneName;

	public void NewGame() {
		SceneManager.LoadScene (newGameSceneName);
	}

	public void MainMenu() {
		SceneManager.LoadScene (mainMenuSceneName);
	}

	public void GameOver() {
		SceneManager.LoadScene (gameOverSceneName);
	}

	public void QuitGame() {
		Application.Quit ();
	}

}
