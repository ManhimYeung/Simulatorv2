using UnityEngine;
using StateStuff;
public class ChoppedState : State<TreeAI> {
    private static ChoppedState _instance;
    private ChoppedState() {
        if (_instance != null)
            return;
        _instance = this;
    }
    public static ChoppedState Instance {
        get {
            if (_instance == null)
                new ChoppedState();
            return _instance;
        }
    }
    public override void EnterState(TreeAI _owner) {
        Die(_owner);
    }
    public override void ExitState(TreeAI _owner) {

    }
    public override void UpdateState(TreeAI _owner) {

    }

    void Die(TreeAI _owner) {
        //Debug.Log(_owner + "is being chopped. ");
        Object.Destroy(_owner.gameObject);
    }
}
