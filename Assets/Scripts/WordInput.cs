using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour {

	public WordManager wordManager;

	// Update is called once per frame
	void Update () {
		foreach (char letter in Input.inputString)
		{
			Scores.charTyped++; //Counts how many letters were typed total, might be used to calc accuracy?
			wordManager.TypeLetter(letter);
		}
	}

}
