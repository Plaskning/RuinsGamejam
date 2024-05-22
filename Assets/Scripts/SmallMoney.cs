using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SmallMoney : MonoBehaviour
{
    private Score _score;
    private void OnCollisionEnter(Collision other)
    {
        _score.LoseScore();
        Destroy(gameObject);
    }
}
