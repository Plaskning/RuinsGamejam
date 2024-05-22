using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text moneyText;
    [HideInInspector] public int money;
    [SerializeField] public int startingMoney;

    public void Start()
    {
        money = startingMoney;
        moneyText.SetText(money.ToString());
    }

    public void GainScore(int moneyGain)
    {
        money += moneyGain;
        moneyText.SetText(money.ToString());
    }

    public void LoseScore(int moneyLoss)
    {
        money -= moneyLoss;
        moneyText.SetText(money.ToString());
    }
}
