﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLevel2 : MonoBehaviour
{
    public GameObject level2;

    public bool startLevel=false;

    public BattleMachine battleScript;

    public Text dialogText;
    // Start is called before the first frame update
    void Start()
    {
        battleScript = level2.GetComponent<BattleMachine>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("estás en el nive2 we");
            battleScript.enabled = true;
        }
        else
        {
            battleScript.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ya no estás en el nivel 2 we");
        battleScript.enabled = false;
        dialogText.text = "Virus Destroyer";
    }
}