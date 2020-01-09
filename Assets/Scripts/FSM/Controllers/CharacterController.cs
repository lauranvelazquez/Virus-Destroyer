using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : FSM
{
    private BiowareController _biowareController;
    private HackerController _hackerController;
    private MagoController _magoController;


    [SerializeField] private Button _bioButton;
    [SerializeField] private Button _hackerButton;

    [SerializeField] private Button _magoButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
