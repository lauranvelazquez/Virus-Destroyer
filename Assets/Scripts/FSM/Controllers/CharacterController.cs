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

    private ScoreData _scoreData;

    private int virus;

    // Start is called before the first frame update
    void Start()
    {
    ChooseCharacter();
   
    if (_scoreData.score == 0)
    {
        Loose();
        ChangeScene();
    }
    else if (virus == 0)
    {
        EndGame();
        ChangeScene();
    }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChooseCharacter()
    {
        //si hay alguno antes eliminarlo 
        GameObject Bioware=GameObject.FindObjectOfType<GameObject>();;
        GameObject Mago=GameObject.FindObjectOfType<GameObject>();;
        GameObject Hacker=GameObject.FindObjectOfType<GameObject>();;
        if (_bioButton.IsActive())
        {
            Instantiate(Bioware, new Vector3(0 ,0,0), Quaternion.identity); 
        }

        if (_hackerButton.IsActive())
        {
            Instantiate(Hacker, new Vector3(5 ,0,0), Quaternion.identity); 
        }

        if (_magoButton.IsActive())
        {
            Instantiate(Mago, new Vector3(10 ,0,0), Quaternion.identity); 
        }
    }

    void EndGame()
    {}

    void Loose()
    {
        
    }

    void ChangeScene()
    {
        
    }
        
}
