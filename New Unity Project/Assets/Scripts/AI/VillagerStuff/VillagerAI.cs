﻿using System.Collections;
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
    [HideInInspector]
    public float gameTimer = 0.0f;
    [HideInInspector]
    public float interpolationPeriod = 1.0f;

    /// <summary>
    /// Generic Stats
    /// </summary>
    [HideInInspector]
    public float hunger = 0.0f;
    [HideInInspector]
    public float speed = 1.0f;

    [HideInInspector]
    public TreeAI target;
    [HideInInspector]
    public bool work = false;
    

    public StateMachine<VillagerAI> stateMachine { get; set; }

    // Start is called before the first frame update
    void Start() {
        stateMachine = new StateMachine<VillagerAI>(this);
        /// <summary>
        /// Setting the initial state to Idle
        /// </summary>
        stateMachine.ChangeState(IdleState.Instance);
        work = true;
    }

    // Update is called once per frame
    void Update() {
        if (work == true)
            stateMachine.ChangeState(WorkState.Instance);
        stateMachine.Update();
    }

    void Die() {
        stateMachine.ChangeState(DeathState.Instance);
    }

    void genericStatsCalc()
    {
        hunger += gameTimer;
        if (hunger >= 500.0f)
        {
            hunger = 500.0f;
        }
    }
    
}
