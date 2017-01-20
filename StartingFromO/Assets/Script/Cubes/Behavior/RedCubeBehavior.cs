using UnityEngine;
using System.Collections;

public class RedCubeBehavior : MonoBehaviour {
	
	public int startingHealth = 3; 
	public int currentHealth;  

	bool isDead;                                                // Whether the player is dead.
	//bool damaged;


	void Start () {
	
	}

	public void TakeDamage (int amount)
	{
		// Set the damaged flag so the screen will flash.
		//damaged = true;

		// Reduce the current health by the damage amount.
		currentHealth -= amount;

		// Set the health bar's value to the current health.
		//healthSlider.value = currentHealth;

		// Play the hurt sound effect.
		//playerAudio.Play ();

		// If the player has lost all it's health and the death flag hasn't been set yet...
		if(currentHealth <= 0 && !isDead)
		{
			// ... it should die.
			Death ();
		}
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (currentHealth);
	}

	void Death ()
	{
		// Set the death flag so this function won't be called again.
		isDead = true;

		Destroy (gameObject);
		// Turn off any remaining shooting effects.
		//playerShooting.DisableEffects ();

		// Tell the animator that the player is dead.
		//anim.SetTrigger ("Die");

		// Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
		//playerAudio.clip = deathClip;
		//playerAudio.Play ();

		// Turn off the movement and shooting scripts.
		//playerShooting.enabled = false;
	}
}
