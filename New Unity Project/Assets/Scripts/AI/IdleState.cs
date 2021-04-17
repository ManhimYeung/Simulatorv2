using UnityEngine;
using StateStuff;
public class IdleState : State<VillagerAI> {
    private static IdleState _instance;
    private IdleState() {
        if (_instance != null)
            return;
        _instance = this;
    }
    public static IdleState Instance {
        get {
            if (_instance == null)
                new IdleState();
            return _instance;
        }
    }
    public override void EnterState(VillagerAI _owner) {

    }
    public override void ExitState(VillagerAI _owner) {

    }
    public override void UpdateState(VillagerAI _owner) {

    }
}
