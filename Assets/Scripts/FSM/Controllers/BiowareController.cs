using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BiowareController : FSM
{
    public int position;

    public int velocity;

    public int shootingPoints;
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(new IddleState());
    }

    // Update is called once per frame
    void Update()
    {
        Button shootButton = GetComponent<Button>();
        Button fightButton = GetComponent<Button>();

        if (shootingPoints==100)
        {
            shootButton.onClick.AddListener(ShootOnClick);
        }
        else
        {
            Debug.Log("you dont have shooting points to do this action");
        }
        
        fightButton.onClick.AddListener(FightOnClick);
       
    }

    void ShootOnClick()
    {
      SwitchState(new ShootingState());
      shootingPoints = 0;
    }

    void FightOnClick()
    {
        SwitchState(new FightingState());
    }

}
