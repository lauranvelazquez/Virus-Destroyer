using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Hacker : MonoBehaviour
{
    private States _states;

    private ScoreData _scoreData;
    
    [SerializeField] private KeyCode bugKey, copyKey, stealKey;
    
    private SimpleMovement _movement;

    public void ChooseHackerState()
    {
        _states.Iddle();
        
        if (Input.GetKey(bugKey)) 
            _states.Bug();
        else if(Input.GetKey(copyKey)&& _states._copyLimit<=0) 
            _states.Copy();
        else if (_scoreData.shootingPoints == 100 && Input.GetKey(stealKey))
            _states.Steal();
        else
        {
            _states.Iddle();
            Debug.Log("Hacker-Iddle");
        }
    }
    

    
}
