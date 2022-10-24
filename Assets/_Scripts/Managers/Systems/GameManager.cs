using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameState State;
    public static event Action<GameState> OnGameStateChanged;
    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        UpdateGameState(GameState.ShowMainMenu);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;
        switch (newState)
        {
            case GameState.ShowMainMenu:
                HandleShowMainMenu();
                break;
            case GameState.SelectLevel:
                break;
            case GameState.PlayingLevel:
                break;
            case GameState.LostLevel:
                break;
            case GameState.WonLevel:
                break;
        }
        OnGameStateChanged?.Invoke(newState);
    }

    private void HandleShowMainMenu()
    {
        SceneLoader.LoadScene(SceneLoader.SceneIndex.MainMenu);
    }
}


public enum GameState
{
    ShowMainMenu,
    SelectLevel,
    PlayingLevel,
    LostLevel,
    WonLevel,
    ShowScores
}