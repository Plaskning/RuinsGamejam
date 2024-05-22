using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text moneyText;
    [SerializeField] public int startingMoney;
    [SerializeField] private ScoreSO _scoreSo;

    public void Start()
    {
        _scoreSo._score = startingMoney;
        moneyText.SetText(_scoreSo._score.ToString());
    }

    public void GainScore(int moneyGain)
    {
        _scoreSo._score += moneyGain;
        moneyText.SetText(_scoreSo._score.ToString());
    }

    public void LoseScore(int moneyLoss)
    {
        _scoreSo._score -= moneyLoss;
        moneyText.SetText(_scoreSo._score.ToString());
    }
}
