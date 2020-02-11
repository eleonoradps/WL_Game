using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerTurnManager : MonoBehaviour
{
    // private static Timer timerP1;
    // private static Timer timerP2;

    //System.Timers.Timer timerP1 = new System.Timers.Timer();
    //System.Timers.Timer timerP2 = new System.Timers.Timer();

    [SerializeField] private float gameTimer = 0;

    enum State
    {
        PLAYER_1,
        PLAYER_2,
        PLAYER1_TURN,
        PLAYER2_TURN
    }

    State state = State.PLAYER_1;

    void Start()
    {
        gameTimer = 0;
    }

    void Update()
    {
        switch(state)
        {
            case State.PLAYER_1:
                state = State.PLAYER1_TURN;
                gameTimer += Time.deltaTime;
                break;

            case State.PLAYER_2:
                state = State.PLAYER2_TURN;
                gameTimer += Time.deltaTime;
                break;

        }
    }
}
