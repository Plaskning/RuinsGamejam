using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text moneyText;
    [HideInInspector] public int money;
    [SerializeField] public int moneyGain;
    [SerializeField] public int moneyLoss;

    public void Start()
    {
        money = 0;
    }

    public void GainScore()
    {
        money += moneyGain;
        moneyText.SetText(money.ToString());
    }

    public void LoseScore()
    {
        money -= moneyLoss;
        moneyText.SetText(money.ToString());
    }
}
