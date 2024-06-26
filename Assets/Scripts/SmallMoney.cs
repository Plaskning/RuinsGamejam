using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SmallMoney : MonoBehaviour
{
    private Score _score;
    private GameObject UI;

    private void Awake()
    {
        UI = GameObject.FindGameObjectWithTag("UI");
        if(UI.TryGetComponent(out Score score))
        {
            _score = score;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _score.LoseScore(50);
            Destroy(gameObject);
        }
        
    }
}
