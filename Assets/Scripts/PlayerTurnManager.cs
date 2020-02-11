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

    private bool pausedPlayer1 = false;
    private bool pausedPlayer2 = false;

    [SerializeField] private GameObject panelPlayer1UI;
    [SerializeField] private GameObject panelPlayer2UI;

    public GameObject PanelPlayer1UI
    {
        get => panelPlayer1UI;
        set => panelPlayer1UI = value;
    }

    public GameObject PanelPlayer2UI
    {
        get => panelPlayer2UI;
        set => panelPlayer2UI = value;
    }

    [SerializeField] private float playerTurnTimer = 0;

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
        playerTurnTimer = 0;
    }

    void Update()
    {
        switch(state)
        {
            case State.PLAYER_1:
                state = State.PLAYER1_TURN;
                Player1Turn();
                NotPlayer2Turn();
                playerTurnTimer += Time.deltaTime;
                break;

            case State.PLAYER_2:
                state = State.PLAYER2_TURN;
                Player2Turn();
                NotPlayer1Turn();
                playerTurnTimer += Time.deltaTime;
                break;

        }
    }

    public void Player1Turn()
    {
        PanelPlayer1UI.SetActive(false);
        Time.timeScale = 1f;
        pausedPlayer1 = false;
    }

    public void Player2Turn()
    {
        PanelPlayer2UI.SetActive(false);
        Time.timeScale = 1f;
        pausedPlayer2 = false;
    }

    public void NotPlayer1Turn()
    {
        PanelPlayer1UI.SetActive(true);
        Time.timeScale = 0f;
        pausedPlayer1 = true;
    }

    public void NotPlayer2Turn()
    {
        PanelPlayer2UI.SetActive(true);
        Time.timeScale = 0f;
        pausedPlayer2 = true;
    }
}
