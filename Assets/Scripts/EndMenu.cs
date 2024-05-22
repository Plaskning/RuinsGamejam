using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private ScoreSO _scoreSo;
    public TMP_Text moneyText;
    [HideInInspector] public int money;

    private void Start()
    {
        moneyText.SetText(_scoreSo.score.ToString());
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
