using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States 
{
    public string _currentEvent;
    private ScoreData _scoreData;
    
    public int _copyLimit=3;
     public void Iddle()
    {
        
    }

    public void Die()
    {
        
    }

    public void Copy()
    {
        switch (_currentEvent)
        {
            case "steal":
                Steal();
                break;
            case "bug":
                Bug();
                break;
            case "shoot":
                Shoot();
                break;
            case "block":
                Block();
                break;
            case "attack":
                Attack();
                break;
            case "fight":
                Fight();
                break;
            case "scanner":
                Scanner();
                break;
            case "light":
                Light();
                break;
            case "invisibility":
                Invisibility();
                break;
            case "doubling":
                Doubling();
                break;
            case"pixel":
                Pixeling();
                break;
            case"electricity":
                Electricity();
                break;
            default:
                Iddle();
                break;
        }

        Debug.Log("Hacker - case2");
        _copyLimit--;
    }

    public void Steal()
    {
        Debug.Log("Hacker - case3");
        _scoreData.shootingPoints = 0;
        _currentEvent = "steal";
    }

    public void Bug()
    {
        Debug.Log("Hacker - case1");
        _currentEvent = "Bug";
    }

     public void Shoot()
     {
         _currentEvent = "shoot";
     }

     public void Electricity()
     {
         _currentEvent = "electricity";
     }

     public void Block()
     {
         _currentEvent = "block";
     }

     public void Attack()
     {
         _currentEvent = "attack";
     }

     public void Invisibility()
     {
         _currentEvent = "invisibility";
     }

     public void Doubling()
     {
         _currentEvent = "doubling";
     }

     public void Pixeling()
     {
         _currentEvent = "pixeling";
     }

     public void Scanner()
     {
         _currentEvent = "scanner";
     }

     public void Light()
     {
         _currentEvent = "light";
     }

     public void Fight()
     {
         _currentEvent = "fight";
     }
}
