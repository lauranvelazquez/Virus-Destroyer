using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MagoController : FSM
{
    public int position;

    public int velocity;

    public int shootingPoints;

    private int  _electricityLimit;
    
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(new IddleState());
    }

    // Update is called once per frame
    void Update()
    {
        Button electricityButton = GetComponent<Button>();
        Button pixelButton = GetComponent<Button>();
        Button lightButton = GetComponent<Button>();
        
        pixelButton.onClick.AddListener(PixelOnClick);
        
        if(_electricityLimit<=0) electricityButton.onClick.AddListener(ElecOnClick);
        
        if (shootingPoints==100) lightButton.onClick.AddListener(LightOnClick);
    }

    void ElecOnClick()
    {
        SwitchState(new ElectricityState());
        _electricityLimit--;
    }

    void PixelOnClick()
    {
        SwitchState(new PixelingState());
    }

    void LightOnClick()
    {
        SwitchState(new LightningState());
        shootingPoints = 0;
    }
}
