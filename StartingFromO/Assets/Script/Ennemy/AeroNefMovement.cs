using UnityEngine;
using System.Collections;

public class AeroNefMovement : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Turning ();
	}

	void Turning(){
		transform.LookAt(player);
	}

}
