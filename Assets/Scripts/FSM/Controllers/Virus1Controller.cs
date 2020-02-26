using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus1Controller : FSM
{
    private Vector3 _initialPosition; //elegir donde van a ubicarse
    
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = _initialPosition;
        SwitchState(new IddleState());
    }

    // Update is called once per frame
    protected override void Update()
    {
        RandomState.StateLimits = 4;
        
        if (RandomState.StateE == 1)
        {
            SwitchState(new AttackingState());
        }

        if (RandomState.StateE == 2)
        {
            SwitchState(new DieState());
        }

        if (RandomState.StateE == 3)
        {
            //SwitchState();
        }

        if (RandomState.StateE == 4)
        {
            
        }
    }
}
