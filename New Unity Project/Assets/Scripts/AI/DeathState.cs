using UnityEngine;
using StateStuff;
public class DeathState : State<VillagerAI> {
    private static DeathState _instance;
    private DeathState() {
        if (_instance != null)
            return;
        _instance = this;
    }
    public static DeathState Instance {
        get {
            if (_instance == null)
                new DeathState();
            return _instance;
        }
    }
    public override void EnterState(VillagerAI _owner) {
        Die(_owner);
    }
    public override void ExitState(VillagerAI _owner) {

    }
    public override void UpdateState(VillagerAI _owner) {

    }

    void Die(VillagerAI _owner) {
        Debug.Log(_owner + "Died. ");
        Object.Destroy(_owner.gameObject);
    }
}
