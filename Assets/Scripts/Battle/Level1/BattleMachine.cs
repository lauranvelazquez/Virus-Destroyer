using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public enum BattleStates{Start, PlayerTurn, Enemyturn, Won, Lost }
public class BattleMachine : MonoBehaviour
{
    public GameObject mago, hacker, virus1, virus2;

    private Player _player;

    public static bool OnPlayerTurn = true;
    
    //caracteristicas y el nombre
    private Unit MagoUnit; 
    private Unit HackerUnit;
    private Unit Enemy1Unit;
    private Unit Enemy2Unit;
    
     public BattleStates states;
     
    private bool _battle = true;
    
    public ScoreData scoreData;

    private Virus1 _virus1System;
    private Hacker _hackerSystem;
    private Mago _magoSystem;
    
    public Text dialogText; 

    private int _scoreBattleEnemy = 100;

    public static bool IsPlayerChoosing=false;
    public static bool IsEnemyChoosing=false;
    
    // Start is called before the first frame update
      void Start()
    {
        states = BattleStates.Start;
        StartCoroutine(SetUpBattle());
    }

    void Update() 
    {
        
        if (OnPlayerTurn)
        {
            states = BattleStates.PlayerTurn;
            StartCoroutine(PlayerTurn());
        }
        else if (!OnPlayerTurn)
        {
            states = BattleStates.Enemyturn;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator SetUpBattle()
    {
        dialogText.text = "SetUp Battle";
        yield return new WaitForSeconds(1f);
            
        MagoUnit = mago.GetComponent<Unit>();
        HackerUnit = hacker.GetComponent<Unit>();
        Enemy1Unit = virus1.GetComponent<Unit>();
        Enemy1Unit = virus2.GetComponent<Unit>();
    
        dialogText.text = "Battle 1";
        yield return new WaitForSeconds(1f);

        OnPlayerTurn = true;
    }

    IEnumerator EnemyTurn()
    {
        dialogText.text = "Enemy Turn";
        
        //Choose State
        IsEnemyChoosing = true;
        
        if (scoreData.score==0) //el score es la vida de los players
        {
            states = BattleStates.Lost;
            EndBattle();
        }
        yield return new WaitForSeconds(2f);
    }

    IEnumerator PlayerTurn()
    {
        yield return new WaitForSeconds(2f);
        
        if (states != BattleStates.PlayerTurn)
        {
            yield break;
        }
        dialogText.text = "Choose a Player";
        
        //Choose a Player and Attack 
        
        IsPlayerChoosing = true;

        if (_scoreBattleEnemy == 0)
        {
            states = BattleStates.Won;
            EndBattle();
        }

        yield return new WaitForSeconds(2f);
    }
    
    void EndBattle()
    
    {
        if (states == BattleStates.Won)
        {
            dialogText.text = "You won the battle!";
        }
        else if (states == BattleStates.Lost)
        {
            dialogText.text = "You loose";
        }
    }

    
}
