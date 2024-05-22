using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text moneyText;
    [HideInInspector] public int money;

    public void Start()
    {
        money = 0;
    }

    public void GainScore()
    {
        money += 50;
        moneyText.SetText(money.ToString());
    }

    public void LoseScore()
    {
        money -= 50;
        moneyText.SetText(money.ToString());
    }
}
