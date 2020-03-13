using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : MonoBehaviour
{
    [SerializeField] private KeyCode _electricityKey, _pixelKey, _LightingKey;
    private int  _electricityLimit;

    private ScoreData _scoreData;

    private States _states;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseMagoState()
    {
        
        if (Input.GetKey(_pixelKey))
        {
            _states.Pixeling();
            Debug.Log("pixel");
        }
        else if (Input.GetKey(_electricityKey) && _electricityLimit > 0)
        {
            _states.Electricity();
            Debug.Log("Electricity");
        }
        else if (Input.GetKey(_LightingKey)&&_scoreData.shootingPoints==100)
        {
            _states.Light();
            Debug.Log("Light");
        }
        else
        {
            _states.Iddle();
            Debug.Log("Mago-Iddle");
        }
    }
    
}
