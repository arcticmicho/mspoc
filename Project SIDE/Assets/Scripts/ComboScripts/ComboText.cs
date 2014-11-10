using UnityEngine;
using System.Collections;

public class ComboText : MonoBehaviour {

	static GUIText guiText;
	private static string COMBO_TEXT = " Hits!";

	// Use this for initialization
	void Start () {
		guiText = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void setComboText(string text)
	{
		guiText.text = text + COMBO_TEXT;
	}
}
