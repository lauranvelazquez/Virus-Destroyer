using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTree : MonoBehaviour
{
    private int contador = 0;
    private ScoreData _scoreData;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && contador < 4)
        {
            Debug.Log("Tree");
            _scoreData.score++;
        }
    }
}
