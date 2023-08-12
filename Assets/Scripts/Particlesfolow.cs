using UnityEngine;
using System.Collections;

public class Particlesfolow : MonoBehaviour {

	public GameObject targetToFolow;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Space) && EnergyBar.currentEn > 0) 
		{
			gameObject.transform.position = targetToFolow.transform.position;
		}
	}
	void FixedUpdate()
	{
		gameObject.transform.position = new Vector3 (0f, 500f, 0f);
	}
}
