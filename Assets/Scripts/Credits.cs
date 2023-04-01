using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Text PlayerName;
    public Text WordsCorrect;
    public Text CorrectText;
    public Text IncorrectText;
    public Text TotalText;
    public Text TypeAccuracyText;
    
    public static int TypeAccuracy;

    // Start is called before the first frame update
    void Start()
    {
        TypeAccuracy = (int)((float)Scores.correctCharTyped / Scores.charTyped * 100);

        Debug.Log(TypeAccuracy);

        if (ReadInput.playerName == null)
        {
            PlayerName.text = "Player";
        }
        else
        {
            PlayerName.text = ReadInput.playerName.ToString();
        }
        WordsCorrect.text = "Words Typed: " + Scores.wordsTyped.ToString();
        CorrectText.text = "Correct Characters Typed: " + Scores.correctCharTyped.ToString();
        IncorrectText.text = "Incorrect Characters Typed: " + (Scores.charTyped - Scores.correctCharTyped).ToString();

        TotalText.text = "Total Characters Typed: " + Scores.charTyped.ToString();
        TypeAccuracyText.text = "Type Accuracy: " + TypeAccuracy.ToString() + " %";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
