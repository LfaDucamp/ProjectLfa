using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlueCubeNbrs : MonoBehaviour
{
	public static int bluescore;


	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		bluescore = 10;
	}


	void Update ()
	{
		text.text = "x " + bluescore;
	}
}
