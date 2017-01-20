using UnityEngine;
using System.Collections;

public class PlayerSpawnCubes : MonoBehaviour {

	public Rigidbody WhiteCubePrefab;
	public Rigidbody RedCubePrefab;
	public Rigidbody BlackCubePrefab;
	public Rigidbody GreenCubePrefab;

	public Transform origin;
	public Transform origin_behind;

	public float delayShoot = 0.5f;
	public float nextTimeFire;

	public float WhiteCubes = 20;
	public float RedCubes = 10;
	public float BlackCubes = 2;
	public float GreenCubes = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > nextTimeFire && WhiteCubes>0) {
			SpawnCube ();
			WhiteCubes -= 1;
			WhiteCubeNbrs.whitescore -= 1;
			if (WhiteCubes < 1) {
				WhiteCubes = 0;
			}
		}

		if (Input.GetButton ("Fire2") && Time.time > nextTimeFire && RedCubes>0) {
			SpawnRedCube ();
			RedCubes -= 1;
			RedCubeNbrs.redscore -= 1;
			if (RedCubes < 1) {
				RedCubes = 0;
			}
		}

		if (Input.GetButton ("Jump") && Time.time > nextTimeFire && BlackCubes>0) {
			SpawnBlackCube ();
			BlackCubes -= 1;
			BlackCubeNbrs.blackscore -= 1;
			if (BlackCubes < 1) {
				BlackCubes = 0;
			}
		}

		if (Input.GetButton ("Action1")&& Time.time > nextTimeFire && GreenCubes>0) {
			SpawnGreenCube ();
			GreenCubes -= 1;
			GreenCubeNbrs.greenscore -= 1;
			if (GreenCubes < 1) {
				GreenCubes = 0;
			}
		}

	}


	void SpawnCube(){

			nextTimeFire = Time.time + delayShoot;
			Rigidbody instance;
		    instance = Instantiate (WhiteCubePrefab, origin.position, origin.rotation) as Rigidbody;
			instance.AddForce (origin.forward);

		
	}
	void SpawnRedCube (){
		nextTimeFire = Time.time + delayShoot;
		Rigidbody instance;
		instance = Instantiate (RedCubePrefab, origin.position, origin.rotation) as Rigidbody;
		instance.AddForce (origin.forward);
	}

	void SpawnBlackCube (){
		nextTimeFire = Time.time + delayShoot;
		Rigidbody instance;
		instance = Instantiate (BlackCubePrefab,origin_behind.position, origin_behind.rotation) as Rigidbody;
		instance.AddForce (origin_behind.forward);
	}

	void SpawnGreenCube (){
		nextTimeFire = Time.time + delayShoot;
		Rigidbody instance;
		instance = Instantiate (GreenCubePrefab,origin.position, origin.rotation) as Rigidbody;
		instance.AddForce (origin.forward);
	}
}
