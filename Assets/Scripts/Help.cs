using UnityEngine;
using System.Collections;

public class Help : MonoBehaviour {

	void Update () 
	{
		transform.Rotate(new Vector3(0f,45f,0f) * Time.deltaTime);
	}
}
