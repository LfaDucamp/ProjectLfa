using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {
	
	PlayerHealth playerHealth; 
	GameObject player;
	Animator anim;
	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(playerHealth.currentHealth < 1)
		{
			anim.SetBool ("IsDead", true);

		}
	}
}
