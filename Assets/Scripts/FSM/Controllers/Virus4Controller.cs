using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Virus4Controller : FSM
{
    private float _initialTime;

    private float _currentTime;

    [SerializeField] private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        SwitchState(new IddleState());
        Debug.Log("Virus4 - Iddle");
        this.transform.position = initialPosition;
        _initialTime = 0.0f;
        _initialTime = _currentTime;
    }
    
    // Update is called once per frame
    protected override void Update()
    {
        switch (_currentTime)
        {
            case 0.0f:
                RandomState.StateLimits = 3;
                break;
            case 1.0f:
                RandomState.StateLimits = 6;
                break;
            case 2.0f:
                RandomState.StateLimits = 9;
                break;
            case 3.0f:
                RandomState.StateLimits = 12;
                break;
            case 4.0f:
                RandomState.StateLimits = 15;
                break;
            default:
                Debug.Log("Error. The sistem has been broken");
                break;
        }

        _currentTime = Time.deltaTime;

        switch (RandomState.StateE)
        {
            case 1:
                SwitchState(new AttackingState());
                Debug.Log("Virus4 - case1");
                Battle.ChangeTurn();
                break;
            case 2:
                SwitchState(new FightingState());
                Debug.Log("Virus4 - case2");
                Battle.ChangeTurn();
                break;
            case 3:
                SwitchState(new ScannerState());
                Debug.Log("Virus4 - case3");
                Battle.ChangeTurn();
                break;
            case 4:
                SwitchState(new CopyingState());
                Debug.Log("Virus4 - case4");
                Battle.ChangeTurn();
                break;
            case 5:
                SwitchState(new BuggingState());
                Debug.Log("Virus4 - case5");
                Battle.ChangeTurn();
                break;
            case 6:
                SwitchState(new LightningState());
                Debug.Log("Virus4 - case6");
                Battle.ChangeTurn();
                break;
            case 7:
                SwitchState(new BlockingState());
                Debug.Log("Virus4 - case8");
                Battle.ChangeTurn();
                break;
            case 8:
                SwitchState(new DoublingState());
                Debug.Log("Virus4 - case8");
                Battle.ChangeTurn();
                break;
            case 9:
                SwitchState(new StealingState());
                Debug.Log("Virus4 - case9");
                Battle.ChangeTurn();
                break;
            case 10:
                SwitchState(new InvisibilityState());
                Debug.Log("Virus4 - case10");
                Battle.ChangeTurn();
                break;
            case 11:
                SwitchState(new PixelingState());
                Debug.Log("Virus4 - case11");
                Battle.ChangeTurn();
                break;
            case 12:
                SwitchState(new ElectricityState());
                Debug.Log("Virus4 - case12");
                Battle.ChangeTurn();
                break;
            case 13:
                SwitchState(new ShootingState());
                Debug.Log("Virus4 - case13");
                Battle.ChangeTurn();
                break;
            default:
                SwitchState(new IddleState());
                Debug.Log("Error. The sistem has been broken");
                Battle.ChangeTurn();
                break;
        }
    }
}
