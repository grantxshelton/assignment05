using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void ReplayGame()
    {
        Scores.lives = 5;
        Scores.charTyped = 0;
        Scores.correctCharTyped = 0;
        SceneManager.LoadScene("Main");
    }
}
