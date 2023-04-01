using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    public static int charTyped;
    public static int correctCharTyped;
    public static int lives = 5;
    public static int Incorrect;
    public static int wordsTyped;

    public Text incorrectText;
    public Text correctCharTypedText;
    public Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        incorrectText.text = "Incorrect: " + (charTyped - correctCharTyped).ToString();
        correctCharTypedText.text = "Correct: " + correctCharTyped.ToString();
        livesText.text = "LIVES : " + lives.ToString();

        //TypeAccuracy = (correctCharTyped / charTyped) * 100;
       // Debug.Log(TypeAccuracy);

        if (lives == 0)
        {
            SceneManager.LoadScene("Credits");
        }

    }
}
