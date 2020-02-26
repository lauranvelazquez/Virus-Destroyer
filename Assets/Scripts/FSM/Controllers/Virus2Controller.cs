using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Versioning;
using UnityEditor.UIElements;
using UnityEngine;
using Object = UnityEngine.Object;

public class Virus2Controller : FSM
{
    private bool _isNear;
    private bool _playerAttack;


    // Start is called before the first frame update
    private void Awake()
    {
       
    }

    void Start()
    {
        VirusInTurn();
        return;
    }

    void VirusInTurn()
    {
        if (_isNear)
        {
            SwitchState(new ShootingState());
        }

        if (_playerAttack)
        {
            SwitchState(new BlockingState());
        }
        else
        {
            SwitchState(new StealingState());
        }
        {
            
        }
    }
    // Update Inis called once per frame
    void Update()
    {
    }
}
