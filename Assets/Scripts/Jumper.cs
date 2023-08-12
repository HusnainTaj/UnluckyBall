using UnityEngine;
using System.Collections;

public class Jumper : MonoBehaviour {

	public AudioClip jumpSound;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player")) 
		{
			AudioSource.PlayClipAtPoint (jumpSound, other.transform.position);
			PlayerController.rb.AddForce (new Vector3(0f,500f,0f));
		}
	}
}
