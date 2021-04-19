using UnityEngine;
using StateStuff;
public class HuntState : State<VillagerAI>
{
    private static HuntState _instance;
    private HuntState()
    {
        if (_instance != null)
            return;
        _instance = this;
    }
    public static HuntState Instance
    {
        get
        {
            if (_instance == null)
                new HuntState();
            return _instance;
        }
    }
    public override void EnterState(VillagerAI _owner)
    {

    }
    public override void ExitState(VillagerAI _owner)
    {
        Debug.Log("Exiting Idle state. ");
    }
    public override void UpdateState(VillagerAI _owner)
    {

    }

}
