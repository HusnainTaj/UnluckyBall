using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	public static Rigidbody rb;

	private int count;

	public Text countText;

	public Text winText;

	public AudioClip pickUpSound;

	public AudioClip winSound;

	public float limit;

	public static int currentLevel = 2;

	public GameObject levelCompleted;

	public GameObject levelLost;

	public AudioClip lostSound;

	public GameObject levelHelp;

	public static GameObject self;

	public GameObject wallParticles;

	public void Start(){
	
		rb = GetComponent<Rigidbody> ();
		count = 0;
		winText.text = "";
		levelCompleted.gameObject.SetActive (false);
		levelLost.gameObject.SetActive (false);
		levelHelp.gameObject.SetActive (false);
		self = this.gameObject;
		self.gameObject.SetActive (false);
	}
	void Update(){
		if(rb.transform.position.y < limit)
		{
			AudioSource.PlayClipAtPoint (lostSound, rb.transform.position);
			gameObject.SetActive (false);
			EnergyBar.currentEn = 0;
			levelLost.gameObject.SetActive (true);
		}
	}
	public void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);
		rb.AddForce (movement * moveSpeed);
		levelHelp.gameObject.SetActive (false);
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Pick Up")){

			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
			AudioSource.PlayClipAtPoint (pickUpSound, other.transform.position);
		}
		if (other.gameObject.tag == "EnergyCharger") 
		{
			EnergyBar.currentEn += 50;
			if (EnergyBar.currentEn > 100) 
			{
				EnergyBar.currentEn = 100;
			}
			other.gameObject.transform.parent.gameObject.SetActive(false);
		}
	}
	void OnTriggerStay(Collider help)
	{
		if (help.gameObject.tag == "Help") 
		{
			levelHelp.gameObject.SetActive (true);
		} 
	}
	void OnCollisionEnter(Collision col)
	{
		if(self.gameObject.tag == "Superman" && col.gameObject.tag == "Breakable")
		{
			col.gameObject.SetActive (false);
			Instantiate (wallParticles, col.gameObject.transform.position, Quaternion.identity);
		}
	}
	void SetCountText(){
	
		countText.text = "Gold Collected: " + count.ToString ();
		if(count >= 13)
		{
			winText.text = "You win!";
			AudioSource.PlayClipAtPoint (winSound, gameObject.transform.position);
			self.gameObject.SetActive (false);
			currentLevel++;
			levelCompleted.gameObject.SetActive (true);
		}
	}
}
