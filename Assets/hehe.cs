using UnityEngine;
using System.Collections;

public class hehe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");
		transform.Translate (Vector3.forward*y);
		transform.Translate (Vector3.right * x);
	}
}
