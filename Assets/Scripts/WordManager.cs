using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

	public List<Word> words;

	public AudioSource audioSource;
	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

	public void AddWord()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);

		words.Add(word);
	}

	public void TypeLetter(char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				audioSource.Play();
				Scores.correctCharTyped++; //Adds point if letter typed is in word
				activeWord.TypeLetter();
				
			}
		}
		else
		{
			foreach (Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					audioSource.Play();
					Scores.correctCharTyped++; //Add point if first letter typed is in new word
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
		}
	}

	//I tried to develop this for hours, none of my solutions worked. Chris's solution works perfectly so I am using that.
	public void RemoveWord(Word wordToRemove) //Chris shared this with the class
	{
		if (hasActiveWord && activeWord == wordToRemove)
		{
			hasActiveWord = false;
		}
		words.Remove(wordToRemove);
	}


}
