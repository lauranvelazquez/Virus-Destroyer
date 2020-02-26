
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

    private ScoreData _scoreData;
    
    public static State currentState;

    private GameData _gameData;
    
    [SerializeField]
    private Button bugButton, copyButton, stealButton;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
     SwitchState(new IddleState());   
    }

    // Update is called once per frame
    void Update()
    {

        bugButton.onClick.AddListener(BugOnClick);
        
        if(_copyLimit<=0) copyButton.onClick.AddListener(CopyOnClick);
        
        if (_scoreData.shootingPoints==100) stealButton.onClick.AddListener(StealOnClick);
    }
    void BugOnClick(){
        SwitchState(new BuggingState());
        Debug.Log("Hacker - case1");
        Battle.ChangeTurn();
        _gameData.actualState=new BuggingState();
        
    }

    void CopyOnClick()
    {
        State copy = _gameData.actualState;
        SwitchState(new CopyingState() );
        Debug.Log("Hacker - case2");
        _copyLimit--;
        Battle.ChangeTurn();
        _gameData.actualState=new CopyingState();
    }

    void StealOnClick()
    {
        SwitchState(new StealingState());
        Debug.Log("Hacker - case3");
        _scoreData.shootingPoints = 0;
        Battle.ChangeTurn();
        _currentState = new StealingState();
        _gameData.actualState=new StealingState();
         }
}
