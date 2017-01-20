using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GreenCubeNbrs : MonoBehaviour
{
	public static int greenscore;


	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		greenscore = 10;
	}


	void Update ()
	{
		text.text = "x " + greenscore;
	}
}