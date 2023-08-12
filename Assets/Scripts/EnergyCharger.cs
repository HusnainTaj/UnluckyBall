using UnityEngine;
using System.Collections;

public class EnergyCharger : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (0f, 45f, 0f) * Time.deltaTime);
	}
}
