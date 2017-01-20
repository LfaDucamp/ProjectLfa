using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlackCubeNbrs : MonoBehaviour
{
	public static int blackscore;


	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		blackscore = 2;
	}


	void Update ()
	{
		text.text = "x " + blackscore;
	}
}
