using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public enum BattleState{Start, PlayerTurn, Enemyturn, Won, Lost }

public class BattleSystem : MonoBehaviour
{
    public BattleState state;
    private ScoreData _scoreData;

    public GameObject magoPrefab;
    public GameObject hackerPrefab;
    public GameObject biowarePrefab;
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;

    public Transform playersStation; //donde aparecen
    public Transform virusStation;

    private Unit MagoUnit; //caracteristicas y el nombre
    private Unit BiowareUnit;
    private Unit HackerUnit;
    private Unit Enemy1Unit;
    private Unit Enemy2Unit;

    private Virus2 _virus2System;
    private Virus1 _virus1System;
    private Hacker _hackerSystem;
    private Mago _magoSystem;
    private Bioware _biowareSystem;

    public Text dialogText;

    private int _scoreBattleEnemy = 100;

    private int c = 2;

    // Start is called before the first frame update
    void Start()
    {
        //poner la bandera de si los players se teletransportan
        state = BattleState.Start;
        StartCoroutine(SetUpBattle());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SetUpBattle()
    {
        GameObject MagoGo = Instantiate(magoPrefab, playersStation);
        MagoUnit = MagoGo.GetComponent<Unit>();
        GameObject HackerGo = Instantiate(hackerPrefab, playersStation);
        HackerUnit = HackerGo.GetComponent<Unit>();
        GameObject BiowarerGo = Instantiate(biowarePrefab, playersStation);
        BiowareUnit = BiowarerGo.GetComponent<Unit>();

        GameObject Enemy1Go = Instantiate(enemy1Prefab, virusStation);
        Enemy1Unit = Enemy1Go.GetComponent<Unit>();
        GameObject Enemy2Go = Instantiate(enemy2Prefab, virusStation);
        Enemy2Unit = Enemy2Go.GetComponent<Unit>();

        dialogText.text = Enemy1Unit.unitName;
        yield return new WaitForSeconds(5f);
        dialogText.text = Enemy2Unit.unitName;

        state = BattleState.PlayerTurn;
        PlayerTurn();
    }

    void PlayerTurn()
    {
        dialogText.text = "Choose an action";

        if (state != BattleState.PlayerTurn)
        {
            return;
        }

        StartCoroutine(PlayerAttack());
    }


    IEnumerator PlayerAttack()
    {

        Debug.Log("Choose a Player");
       // StartCoroutine(PlayerAttack());


        yield return new WaitForSeconds(5f);
        //detectar el daño de los enemigos

        if (_scoreBattleEnemy == 0)
        {
            state = BattleState.Won;
            EndBattle();
        }
        else
        {
            state = BattleState.Enemyturn;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator EnemyTurn()
    {

        dialogText.text = " Enemy attacks!";
        if (c % 2 == 0) //para que ataque uno por vez
        {

            _virus2System.ChooseStateVirus1();
        }
        else
        {
            _virus1System.ChooseStateVirus1();
        }

        yield return new WaitForSeconds(1f);

        //detectar el daño de los players

        yield return new WaitForSeconds(1f);

        if (_scoreData.score == 0) //el score es la vida de los players
        {
            state = BattleState.Lost;
            EndBattle();
        }
        else
        {
            state = BattleState.PlayerTurn;
            PlayerTurn();
        }

        c++;

    }

    void EndBattle()
    {
        if (state == BattleState.Won)
        {
            dialogText.text = "You won the battle!";
        }
        else if (state == BattleState.Lost)
        {
            dialogText.text = "You loose";
        }
    }

    void ChoosePlayer()
    {
        
        if (Input.GetKey(KeyCode.H))
        {
            _hackerSystem.ChooseHackerState();
            Debug.Log("You selected Hacker");
        }

        if (Input.GetKey(KeyCode.E))
        {

            _magoSystem.ChooseMagoState();
            Debug.Log("You selected Mago");
        }

        if (Input.GetKey(KeyCode.B))
        {
            _biowareSystem.ChooseBiowareState();
            Debug.Log("You selected Bioware");
        }
    }

}
//desactivar el navmesh agent y la velocidad 