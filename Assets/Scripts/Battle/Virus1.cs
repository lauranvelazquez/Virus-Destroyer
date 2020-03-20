﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus1 : MonoBehaviour
{
   private States _states = new States();

   private void Start()
   {
      
   }

   void Update ()
   {
      if (Enemy.IsVirus1Playing)
      {
         RandomState.StateLimits =3 ;
         RandomState.RandomStateMethod();
         Debug.Log("Virus is choosing");
         switch (RandomState.StateE)
         {
            case 1:
               _states.Attack();
               Debug.Log("2-Invisibility");
               Enemy.IsVirus1Playing = false;
               BattleMachine.IsEnemyChoosing = false;
               BattleMachine.OnPlayerTurn = true;
               break;
            case 2:
               _states.Attack();
               Debug.Log("2-Attack");
               Enemy.IsVirus1Playing = false;
               BattleMachine.IsEnemyChoosing = false;
              BattleMachine.OnPlayerTurn = true;
               break;
            case 3:
               _states.Scanner();
               Debug.Log("2-Scanner");
               Enemy.IsVirus1Playing = false;
               BattleMachine.IsEnemyChoosing = false;
               BattleMachine.OnPlayerTurn = true;
               break;
            default:
               Debug.Log("el enemy no hace nada we");
               _states.Iddle();
               Enemy.IsVirus1Playing = false;
               BattleMachine.IsEnemyChoosing = false;
              BattleMachine.OnPlayerTurn = true;
               break;
         }
      }
   }
      
}
