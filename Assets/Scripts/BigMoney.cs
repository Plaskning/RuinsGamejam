using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BigMoney : MonoBehaviour
{
    private Score _score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _score.GainScore(200);
            Destroy(gameObject);
        }
    }
}
