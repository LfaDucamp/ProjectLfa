using UnityEngine;
using System;

public class TowerMovement : MonoBehaviour
{
	
	Vector3 movement;
	//Rigidbody playerRigidbody;
	//int floorMask;
	//float camRayLength = 100f;
	public Rigidbody projectile;
	public float speed = 6f;
	public Transform player;
	public Transform origin;
	public int force = 50;
	public float delayShoot = 0.5f;
	public float nextTimeFire;

	Light gunLight;
	//float JumpSpeed = 100f;
	//float j = 0;
	//Animator anim;
	void Awake(){
		gunLight = GameObject.Find("GunLightTourelle").GetComponent<Light>();
		gunLight.enabled = false;
		//floorMask = LayerMask.GetMask ("Floor");
		//anim = GetComponent<Animator> ();
		//player = GameObject.Find("Player");
		//playerRigidbody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){
	}

	void Update(){
		

	}

	void OnTriggerStay(Collider other){
		if (other.tag == "Player") {
			
			//Debug.Log ("Dedans");
			Turning ();
			Shoot ();
		}
	}

	void Turning(){
		transform.LookAt(player);
	}

	void Shoot(){
		if (Time.time > nextTimeFire) {
			nextTimeFire = Time.time + delayShoot;
			Rigidbody instance;
			instance = Instantiate (projectile, origin.position, origin.rotation) as Rigidbody;
			instance.AddForce (origin.forward * force);
			gunLight.enabled = true;
		} else {
			gunLight.enabled = false;
		}
	}
}

		/*void Animating(float h, float v){
		bool walking = h != 0f || v != 0f;
		anim.SetBool ("IsWalking", walking);
	}*/

