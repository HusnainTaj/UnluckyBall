using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public GameObject loadLevelBtn;
	public GameObject levelStart;

	public void Play(string play)
	{
		SceneManager.LoadScene (play);
	}
	public void Exit()
	{
		Application.Quit ();
	}
	public void Return()
	{
		SceneManager.LoadScene (1);
		PlayerController.currentLevel = 2;
	}
	public void Next()
	{
		SceneManager.LoadScene (PlayerController.currentLevel);
	}
	public void Restart()
	{
		SceneManager.LoadScene (PlayerController.currentLevel);
	}
	public void LoadLevel()
	{
		loadLevelBtn.gameObject.SetActive (false);
	}
	public void StartLevel()
	{
		levelStart.gameObject.SetActive (false);
		PlayerController.self.gameObject.SetActive (true);
	}
}
