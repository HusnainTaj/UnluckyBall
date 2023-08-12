using UnityEngine;
using System.Collections;

public class PlayerRotator : MonoBehaviour {

	public float rotateSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float rotateX = Input.GetAxis ("Mouse X");

		if (Input.GetKey(KeyCode.E)) 
		{
			transform.Rotate(0f,rotateX * rotateSpeed,0f);	
		}
		else if (Input.GetKey(KeyCode.Q)) 
		{
			transform.Rotate(0f,rotateX * rotateSpeed,0f);
		}
	}
}
