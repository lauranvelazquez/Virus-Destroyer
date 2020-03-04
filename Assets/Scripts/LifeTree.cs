using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTree : MonoBehaviour
{
    private int contador=0; 
    private ScoreData _scoreData; 
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player") & contador < 4)
        {
            _scoreData.score = _scoreData.score+5;
            Debug.Log("Tree"); 
            contador++;   
        }
    }
}
