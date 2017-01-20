using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YellowCubeNbrs : MonoBehaviour
{
	public static int yellowscore;


	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		yellowscore = 10;
	}


	void Update ()
	{
		text.text = "x " + yellowscore;
	}
}
