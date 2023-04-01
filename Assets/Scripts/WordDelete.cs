using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDelete : MonoBehaviour //Chris shared this with the class
{
    public Canvas canvas;
    public WordManager wordManager;
    public AudioSource audioSource;
    private float minYPosition = -300f;

    void Update()
    {
        for (int i = 0; i < wordManager.words.Count; i++)
        {
            Word word = wordManager.words[i];
            RectTransform rectTransform = word.display.text.GetComponent<RectTransform>();
            if (rectTransform.anchoredPosition.y < minYPosition)
            {
                
                wordManager.RemoveWord(word);
                Destroy(word.display.gameObject);
                i--;
                Scores.lives--; //Subtract a life if it reaches bottom
                audioSource.time = 0.4f;
                audioSource.Play();
            }
        }
    }
}