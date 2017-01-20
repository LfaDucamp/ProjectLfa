using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RedCubeNbrs : MonoBehaviour
{
	public static int redscore;


	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		redscore = 10;
	}


	void Update ()
	{
		text.text = "x " + redscore;
	}
}
