using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BigMoney : MonoBehaviour
{
    private Score _score;
    private void OnCollisionEnter(Collision other)
    {
        _score.GainScore();
        Destroy(gameObject);
    }
}
