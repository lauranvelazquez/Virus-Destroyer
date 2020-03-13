using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus1 : MonoBehaviour
{
   private States _states;
   public void ChooseStateVirus1()
   
   {
      RandomState.StateLimits =3 ;
        
        
      switch (RandomState.StateE)
      {
         case 1:
            _states.Invisibility();
            Debug.Log("2-Invisibility");
            break;
         case 2:
            _states.Attack();
            Debug.Log("2-Attack");
            break;
         case 3:
            _states.Scanner();
            Debug.Log("2-Scanner");
            break;
         default:
            _states.Iddle();
            break;
      }
   }
}
