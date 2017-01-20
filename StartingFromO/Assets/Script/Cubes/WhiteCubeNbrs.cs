using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WhiteCubeNbrs : MonoBehaviour
{
	public static int whitescore;


	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		whitescore = 20;
	}


	void Update ()
	{
		text.text = "x " + whitescore;
	}
}
