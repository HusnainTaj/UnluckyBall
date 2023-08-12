using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour 
{
	public float wait = 15;

	IEnumerator Start()
	{
		PlayerController.currentLevel = 2;
		yield return new WaitForSeconds (wait);
		SceneManager.LoadScene (1);
	}
}
