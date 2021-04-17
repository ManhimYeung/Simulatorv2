using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateStuff;

public class VillagerAI : MonoBehaviour {
    ///<summary>
    /// Villager AI Script
    ///</summary>

    /// <summary>
    /// Adding a game timer for the villager to switch between states
    /// </summary>
    public float gameTimer = 0.0f;

    /// <summary>
    /// Generic Stats
    /// </summary>
    

    public StateMachine<VillagerAI> stateMachine { get; set; }

    // Start is called before the first frame update
    void Start() {
        stateMachine = new StateMachine<VillagerAI>(this);
        /// <summary>
        /// Setting the initial state to Idle
        /// </summary>
        stateMachine.ChangeState(IdleState.Instance);
    }

    // Update is called once per frame
    void Update() { 
        
    }

    void Die() {
        stateMachine.ChangeState(DeathState.Instance);
    }
}
