using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterController1 : MonoBehaviour
{
    [SerializeField] private Transform _panalBattle;

    [SerializeField] private Transform _initialPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision col)
    {
        //NavMeshAgent _navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        
        if (col.gameObject.CompareTag("Teleport1") )
        {
           // _navMeshAgent.enabled = false;
           // transform.position = _panalBattle.position;
        }
        else if (col.gameObject.CompareTag("GoBack"))
        {
            Debug.Log("ola we");
            //_navMeshAgent.enabled = false;
            //transform.position = _initialPosition.position;
        }

       // _navMeshAgent.enabled = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        NavMeshAgent _navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        
        
        Vector3 currentVelocity = _navMeshAgent.velocity;
        
        if (other.collider.CompareTag("Teleport1"))
        {
            _navMeshAgent.enabled = false;

            transform.position = _panalBattle.position;
        }

        if (other.collider.CompareTag("GoBack"))
        {
            _navMeshAgent.enabled = false;
            transform.position = _initialPosition.position;

        }
        _navMeshAgent.velocity = currentVelocity;
        _navMeshAgent.enabled = true;
        _navMeshAgent.enabled = true;
        _navMeshAgent.updatePosition = true;
        _navMeshAgent.updateRotation = true;
    }*/
}
