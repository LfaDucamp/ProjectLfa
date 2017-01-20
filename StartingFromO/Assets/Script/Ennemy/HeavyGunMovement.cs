using UnityEngine;
using System.Collections;

public class HeavyGunMovement : MonoBehaviour {
	public Rigidbody projectile;
	public Transform origin;
	public int force = 50;
	public float delayShoot = 0.5f;
	public float nextTimeFire;
	Light gunLight;

	void Awake(){
		gunLight = GameObject.Find("GunLight").GetComponent<Light>();
		gunLight.enabled = false;
	}
	// Use this for initialization
	void FixedUpdate(){
		Shoot ();
	}

	void Shoot(){
		if(Time.time>nextTimeFire){
			nextTimeFire = Time.time + delayShoot;
			Rigidbody instance;
			instance = Instantiate (projectile, origin.position, origin.rotation) as Rigidbody;
			instance.AddForce (origin.forward * force);
			gunLight.enabled = true;
		}else{
			gunLight.enabled = false;
		}
	}
}
