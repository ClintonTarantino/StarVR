using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Text scoreText;

	[SerializeField]
	Canvas gameOverCanvas;

	int score;

	GameObject[] spawner;

	AudioSource bgMusic;

	void Awake()
	{
		bgMusic = GetComponent<AudioSource>();
	}

	void Start()
	{
		gameOverCanvas.enabled = false;
	}

	public void AddScore (int points)
	{
		score += points;

		//Sending score to UI
		scoreText.text = score.ToString();
	}


	public void GameOver()
	{
		gameOverCanvas.enabled = true;

		//Stop Background music, Enemy and Ring Objects once destroyed
		bgMusic.Stop();
		spawner = GameObject.FindGameObjectsWithTag("Spawner");
		foreach (GameObject spwn in spawner)
			spwn.SetActive(false);	

	}

	public void Restart()
	{
		SceneManager.LoadScene(0);
	}

}
