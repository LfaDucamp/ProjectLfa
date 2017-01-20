using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeTxtMenu : MonoBehaviour {
	
	Text text;

	// Use this for initialization
	void Awake () {
		Debug.Log ("PointerIn");
		text = GameObject.Find("TextMenu").GetComponent <Text> ();
	}
	
	// Update is called once per frame
	public void WhiteTxt () {
		text.text = "Pavé blanc : " + "\n" + "Un bloc simple indestructible ";
	}

	public void RedTxt () {
		text.text = "Pavé rouge : " + "\n" + "Un bloc simple qui peut encaisser 3 attaques avant d'être détruit ";
	}

	public void GreenTxt () {
		text.text = "Prisme vert : " + "\n" + "Un bloc simple indestructible en forme de prisme ";
	}

	public void BlueTxt () {
		text.text = "Pavé bleu : " + "\n" + "Un bloc simple qui progresse de gauche à droite ";
	}

	public void YellowTxt () {
		text.text = "Pavé jaune : " + "\n" + "Un bloc complexe qui ralenti les projectiles qui passent au travers ";
	}

	public void PinkTxt () {
		text.text = "Pavé rose : " + "\n" + "Un bloc simple qui ne dure que 3 secondes ";
	}

	public void BlackTxt () {
		text.text = "Pavé noir : " + "\n" + "Un bloc simple qui apparait sous sous le joueur pour le soulever ";
	}
}
