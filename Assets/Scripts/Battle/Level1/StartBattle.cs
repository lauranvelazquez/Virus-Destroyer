using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBattle : MonoBehaviour
{
    //para el player
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("BattleBase"))
        {
            //empezar la pelea 
        }
    }
}
