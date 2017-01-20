using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinkCubeNbrs : MonoBehaviour
{
	public static int pinkscore;


	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		pinkscore = 10;
	}


	void Update ()
	{
		text.text = "x " + pinkscore;
	}
}
