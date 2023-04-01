using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class WordGenerator : MonoBehaviour {

	private static string[] wordList;

	static WordGenerator()
	{
		string filePath = "Assets/words.txt"; //Reads words.txt that has 1000 random words
		wordList = File.ReadAllLines(filePath);
	}

    public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
