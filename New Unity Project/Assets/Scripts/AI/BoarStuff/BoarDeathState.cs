using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateStuff;

public class BoarDeathState : State<BoarAI>
{
    private static BoarDeathState _instance;
    private BoarDeathState()
    {
        if (_instance != null)
            return;
        _instance = this;
    }
    public static BoarDeathState Instance
    {
        get
        {
            if (_instance == null)
                new BoarDeathState();
            return _instance;
        }
    }
    public override void EnterState(BoarAI _owner)
    {
        Die(_owner);
    }
    public override void ExitState(BoarAI _owner)
    {

    }
    public override void UpdateState(BoarAI _owner)
    {

    }

    void Die(BoarAI _owner)
    {
        Debug.Log(_owner + "Died. ");
        Object.Destroy(_owner.gameObject);
    }
}
