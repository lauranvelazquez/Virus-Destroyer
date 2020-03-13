using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus2 : MonoBehaviour
{
    private Vector3 _initialPosition;
    
    private bool _isNear; //cercania
    private bool _playerAttack; // algún ataque fuerte
    private States _states;
    
    [SerializeField] private MovementVirus2 _movementVirus2;
    // Start is called before the first frame update
    

    public void ChooseStateVirus1()
    {
        
        _states.Iddle();
        this.transform.position = _initialPosition;
        PlayersCercany();
        
        if (_isNear)
        {
            _states.Shoot();
            Debug.Log("2-Shoot");
            
        }

        else if (_playerAttack==true)
        {
            _states.Block();
            Debug.Log("2-Blocking");
        }
        else if(_playerAttack==false)
        {
            _states.Steal();
            Debug.Log("2-Steal");
        }
        else
        {
            _states.Iddle();
            Debug.Log("2-Iddle");
        }
    }

    void PlayersCercany()
    {
        //usar radio para ver si esta cerca
    }
    
}
