using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class InputFeildManager : MonoBehaviour {

	public void loadLevelByCode(string code)
	{
		if (code == "Rollevel)!") //Level 1//
		{
			SceneManager.LoadScene (2);
			PlayerController.currentLevel = (2);
		}
		else if(code == "Rollevel)@")//Level 2//
		{
			SceneManager.LoadScene (3);
			PlayerController.currentLevel = (3);
		}
		else if(code == "Rollevel)#")//Level 3//
		{
			SceneManager.LoadScene (4);
			PlayerController.currentLevel = (4);
		}
		else if(code == "Rollevel)$")//Level 4//
		{
			SceneManager.LoadScene (5);
			PlayerController.currentLevel = (5);
		}
		else if(code == "Rollevel)%")//Level 5//
		{
			SceneManager.LoadScene (6);
			PlayerController.currentLevel = (6);
		}
		else if(code == "Rollevel)^")//Level 6//
		{
			SceneManager.LoadScene (7);
			PlayerController.currentLevel = (7);
		}
		else if(code == "Rollevel)&")//Level 7//
		{
			SceneManager.LoadScene (8);
			PlayerController.currentLevel = (8);
		}
		else if(code == "Rollevel)*")//Level 8//
		{
			SceneManager.LoadScene (9);
			PlayerController.currentLevel = (9);
		}
		else if(code == "Rollevel)(")//Level 9//
		{
			SceneManager.LoadScene (10);
			PlayerController.currentLevel = (10);
		}
		else if(code == "Rollevel!)")//Level 10//
		{
			SceneManager.LoadScene (11);
			PlayerController.currentLevel = (11);
		}
		else if(code == "Rollevel!!")//Level 11//
		{
			SceneManager.LoadScene (12);
			PlayerController.currentLevel = (12);
		}
	}
}
