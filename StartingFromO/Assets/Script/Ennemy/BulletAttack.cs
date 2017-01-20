using UnityEngine;
using System.Collections;

public class BulletAttack : MonoBehaviour {

	public int attackDamage = 10; 
	public int blocDamage = 1;
	PlayerHealth playerHealth; 
	RedCubeBehavior redcubehealth;
	GameObject player;
	GameObject destroyable;

	void Awake() {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();

		destroyable = GameObject.FindGameObjectWithTag ("Destroyable");
		redcubehealth = destroyable.GetComponent <RedCubeBehavior> ();
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			
			Attack ();
			//Debug.Log ("touché");
		}

		if (other.tag == "Destroyable") {

			AttackBlock ();
			//Debug.Log ("touché");
		}
	}


	void OnTriggerExit (Collider other)
	{

	}
	// Update is called once per frame
	void Update () {

	}

	void Attack ()
	{


		// If the player has health to lose...
		if(playerHealth.currentHealth > 0)
		{
			// ... damage the player.
			playerHealth.TakeDamage (attackDamage);
		}
	}
	void AttackBlock ()
	{


		// If the player has health to lose...
		if(redcubehealth.currentHealth > 0)
		{
			// ... damage the player.
			redcubehealth.TakeDamage (blocDamage);
		}
	}

}
