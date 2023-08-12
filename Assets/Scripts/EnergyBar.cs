using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnergyBar : MonoBehaviour 
{
	public GameObject currentBar;

	public static float currentEn;

	public static float maxEn = 100;

	public float maxCharge;

	public AudioClip boostSound;

	public GameObject player;

	void Start()
	{
		currentEn = 100;
	}

	void Update()
	{
		currentBar.transform.localScale = new Vector3 (1f, currentEn/maxEn, 1f);
		if (Input.GetKey(KeyCode.Space)) 
		{
			currentEn -= 30 * Time.deltaTime;
			EnDamage ();
		}
		if (currentEn > 0 && Input.GetKey (KeyCode.Space))
		{
			player.gameObject.tag = "Superman";
		} 
		else 
		{
			player.gameObject.tag = "Player";
		}
		if (currentEn < 0) {
			currentEn = 0;
		}
		if (currentEn >= 100) {
			currentEn = 100;
		}
	}
	void FixedUpdate()
	{
		
	}
	public void EnDamage()
	{
		if (currentEn > 0) 
		{
			AudioSource.PlayClipAtPoint (boostSound , PlayerController.rb.transform.position);
			PlayerController.rb.AddForce (new Vector3(PlayerController.rb.transform.position.x, PlayerController.rb.transform.position.y, maxCharge));
		}
		currentBar.transform.localScale = new Vector3 (1f, currentEn/maxEn, 1f);
		if (currentEn <= 0.0) {
			currentBar.transform.localScale = new Vector3 (1f, 0.0f, 1f);
		}
	}
}

