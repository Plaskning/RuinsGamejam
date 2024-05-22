using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using TMPro;

public class MoneyPickup : MonoBehaviour
{
    private Score _score;
    private GameObject UI;
    [SerializeField] int money;
    private TMP_Text costText;

    private void Awake()
    {
        costText = GetComponentInChildren<TMP_Text>();

        UI = GameObject.FindGameObjectWithTag("UI");
        if (UI.TryGetComponent(out Score score))
        {
            _score = score;
        }

        costText.SetText(money.ToString());

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _score.GainScore(money);
            Destroy(gameObject);
        }
        
    }
}
