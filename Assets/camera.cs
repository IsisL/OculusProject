using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public Transform cam;
	public float dist;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = cam.transform.position;
		transform.rotation = cam.transform.rotation;
		transform.Translate (Vector3.forward * -dist);
		transform.Translate (Vector3.up * dist);
		transform.LookAt (cam);
	}
}
//Manshant 