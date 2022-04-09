using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen: MonoBehaviour
{
    public void RestartLevel ()
    {
        Debug.Log("RESTART TRIGGERED");
        //meload ulang scene dengan index 0 pada build setting
        SceneManager.LoadScene (1);
    }

    public void BackToMainMenu ()
    {
        SceneManager.LoadScene(0);
    }
}
