using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linePoints : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private drawLine line;

    private void Start() {
        line.SetUpLine(points);
    }
}