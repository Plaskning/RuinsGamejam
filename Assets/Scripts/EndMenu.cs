using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void RetryGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene("MenuTest");
    }
}
