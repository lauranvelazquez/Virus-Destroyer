using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HackerController : FSM
{
    public int position;

    public int velocity;

    private int _copyLimit=3;

    public int shootingPoints;
    
    
    // Start is called before the first frame update
    void Start()
    {
     SwitchState(new IddleState());   
    }

    // Update is called once per frame
    void Update()
    {
        Button bugButton = GetComponent<Button>();
        Button copyButton = GetComponent<Button>();
        Button stealButton = GetComponent<Button>();
        
        bugButton.onClick.AddListener(BugOnClick);
        
        if(_copyLimit<=0) copyButton.onClick.AddListener(CopyOnClick);
        
        if (shootingPoints==100) stealButton.onClick.AddListener(StealOnClick);
    }
    void BugOnClick(){
        SwitchState(new BuggingState());
    }

    void CopyOnClick()
    {
        SwitchState(new CopyingState());
        _copyLimit--;
    }

    void StealOnClick()
    {
        SwitchState(new StealingState());
        shootingPoints = 0;
    }
}
