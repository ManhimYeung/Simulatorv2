using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateStuff;

public class TreeAI : MonoBehaviour {
    private int life;
    public StateMachine<TreeAI> stateMachine { get; set; }
    // Start is called before the first frame update
    void Start() {
        stateMachine = new StateMachine<TreeAI>(this);
    }

    // Update is called once per frame
    void Update() {
        
    }
    void Respawn() {
        if (life <= 0)
            stateMachine.ChangeState(ChoppedState.Instance);
    }
}
